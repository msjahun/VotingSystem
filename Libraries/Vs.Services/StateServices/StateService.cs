using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vs.Core.ElectionState;
using Vs.Core.Users;
using Vs.Core.Votes;
using Vs.Data.Repository;
using Vs.Services.CandidatesServices;
using Vs.Services.Descrypto;

namespace Vs.Services.StateServices
{
    public class StateService : IStateService
    {
        private readonly IRepository<Votes> _votesRepo;
        private readonly ICandidatesService _candidateService;
        private readonly IDESAlgorithm _desService;
        private readonly IRepository<ElectionStates> _statesRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRepository<DecryptedVotes> _decryptedVotesRepo;

        public StateService(IRepository<ElectionStates> StatesRepo,
            UserManager<ApplicationUser> userManager,
            IDESAlgorithm desService,
            IHttpContextAccessor httpContextAccessor,
            ICandidatesService candidateService,
            IRepository<Votes> votesRepo,
            IRepository<DecryptedVotes> decryptedVotesRepo
            )
        {

            _votesRepo = votesRepo;

            _candidateService = candidateService;
            _desService = desService;
            _statesRepo = StatesRepo;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _decryptedVotesRepo = decryptedVotesRepo;

        }

        public List<ElectionStage> GetAllStates()
        {
            //returns all states
            var states = from state in _statesRepo.List().ToList()
                         select new ElectionStage
                         {
                             Id = state.Id,
                             StageName = state.StateName,
                             Status = state.Status,
                             IsCurrentStage = state.IsCurrentState
                         };
            return states.ToList();

        }

        public string StateResolverById(int Id)
        {
            var State = _statesRepo.GetById(Id);
            if (State != null)
                return State.StateName;

            return null;

            //gets state name by Id
        }
        public ElectionStates GetCurrentState()
        {
            //gets current State Id
            var State = (from state in _statesRepo.List().ToList()
                         where state.IsCurrentState == true
                         select state).FirstOrDefault();

            return State;

        }


        public ElectionStates GetStateById(long Id)
        {
            //gets current State Id
            var State = (from state in _statesRepo.List().ToList()
                         where state.Id == Id
                         select state).FirstOrDefault();

            if (State != null)
                return State;

            return null;
            //State is null
        }
        public long GetCurrentStateId()
        {
            //gets current State Id
            var State = (from state in _statesRepo.List().ToList()
                         where state.IsCurrentState == true
                         select state).FirstOrDefault();

            if (State != null)
                return State.Id;

            return -1;
            //State is null
        }
        public bool GoToNextState()
        {
            //Goes to next State

            long CurrentStateId = GetCurrentStateId();
            if (CurrentStateId == -1)
            {
                //not found
                //If There is no CurrentState// means either all states are complete
                //or The states have not began, so Start State
                var CompletedStates = from states in _statesRepo.List().ToList()
                                      where states.Status == StateEnum.Complete
                                      select states;
                if (CompletedStates.ToList().Count > 0)
                {
                    //some states have completed, not beginning
                    return false;
                }
                else
                {
                    //no states are complete so you can start the first state

                    var FirstState = _statesRepo.List().FirstOrDefault();
                    FirstState.IsCurrentState = true;
                    FirstState.Status = StateEnum.InProgress;
                    _statesRepo.Update(FirstState);
                    return true;
                }

            }
            else
            {
                var CurrentState = _statesRepo.GetById(CurrentStateId);
                CurrentState.IsCurrentState = false;
                CurrentState.Status = StateEnum.Complete; //complete
                //get Current State,
                //Make IsCurrentState as false and Mark Status as complete 2
                _statesRepo.Update(CurrentState);


                long NextStateId = CurrentStateId + 1;
                var NextState = _statesRepo.GetById(NextStateId);
                if (NextState != null)
                {
                    //NextState Exists
                    NextState.IsCurrentState = true;
                    NextState.Status = StateEnum.InProgress;
                    //if There is another state after that
                    //Mark IsCurrentState as True and Mark Status as Inprogress 1
                    _statesRepo.Update(NextState);
                }
                return true;

            }




        }

        public async Task ResetStateAsync()
        {

            //Reset all states and delete voting data

            var states = from state in _statesRepo.List().ToList()
                         select state;
            foreach (var state in states)
            {
                state.IsCurrentState = false;
                state.Status = StateEnum.Default;
                _statesRepo.Update(state);
            }

            var users = _userManager.Users.ToList();

            foreach (var user in users)
            {
                user.HasAgreedToTermsAndConditions = false;
                user.HasVotedForCandidate = false;
                user.IsRegisteredForElection = false;

                var x = await _userManager.UpdateAsync(user);
            }


            var votes = _votesRepo.List().ToList();

            foreach(var vote in votes)
            {
                _votesRepo.Delete(vote);

            }


            var decryptedVotes = _decryptedVotesRepo.List().ToList();

            foreach(var dvote in decryptedVotes)
            {
                _decryptedVotesRepo.Delete(dvote);
            }
            //Mark All IsCurrentState to false, & Status to 0
            //Delete all the data in the voting table and other tables if required
        }


        public bool ResolveRegistrationPhaseHasBegan()
        {
            //if registration phase is in progress or complete
            long RegistrationPhaseId = 2;

            var RegistrationState = GetStateById(RegistrationPhaseId);
            if (RegistrationState != null)
            {
                if (RegistrationState.Status == StateEnum.InProgress || RegistrationState.Status == StateEnum.Complete)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ResolveRegistrationPhaseHasEnded()
        {
            long RegistrationPhaseId = 2;
            var RegistrationState = GetStateById(RegistrationPhaseId);
            //registration phase is complete


            if (RegistrationState != null)
            {
                if (RegistrationState.Status == StateEnum.Complete)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ResolveVotingPhaseHasBegan()
        {
            long VotingPhaseId = 3;
            var VotingState = GetStateById(VotingPhaseId);

            if (VotingState != null)
            {
                if (VotingState.Status == StateEnum.InProgress || VotingState.Status == StateEnum.Complete)
                {
                    return true;
                }
            }
            //if voting phase is in progress or complete
            return false;
        }

        public bool ResolveVotingPhaseHasEnded()
        {
            long VotingPhaseId = 3;
            var VotingState = GetStateById(VotingPhaseId);
            //if voting phase is complete

            if (VotingState != null)
            {
                if (VotingState.Status == StateEnum.Complete)
                {
                    return true;
                }
            }
            return false;
        }


        public List<BBRegistrationPhase> GetAllUsersWhoHaveRegisteredForElection()
        {
            var users = from User in _userManager.Users.ToList()
                        where User.IsRegisteredForElection == true
                        select new BBRegistrationPhase
                        {
                            UserId = User.Id,
                            FirstName = User.FirstName,
                            LastName = User.LastName,
                            UserName = User.UserName
                        };
            if (users.ToList().Count > 0)
                return users.ToList();
            else
                return null;

        }


        public List<BBVotingPhase> GetAllUsersWhoHaveValidVotes()
        {
            var users = from User in _userManager.Users.ToList()
                        where User.HasVotedForCandidate == true
                        select new BBVotingPhase
                        {
                            UserId = User.Id,
                            FirstName = User.FirstName,
                            LastName = User.LastName,
                            UserName = User.UserName
                        };

            if (users.ToList().Count > 0)
                return users.ToList();
            else
                return null;
        }


        //two methods encrypt and decrypt
        public async Task<bool> VoteForCandidateAsync(long CandidateId)
        {
            //check if user has registered to vote
            //encrypt it into text and add it to votingTable
            //set has votedto true in the userTable for the particular user

            var CurrentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var User = _userManager.Users.Where(_ => _.Id == CurrentUserId).FirstOrDefault();
            if (User != null)
            {
                if (User.IsRegisteredForElection)
                {

                    var Candidate = _candidateService.GetCandidateById(CandidateId);

                    string ToEncrypt = Guid.NewGuid() + " " + Candidate.Id + " " + Candidate.Name;

                    string EncryptedVote = _desService.Encrypt(ToEncrypt, "Musa");

                    var vote = new Votes
                    {
                        CandidateName = EncryptedVote
                        //candidateNameIs the encryptedVote
                    };

                    _votesRepo.Insert(vote);
                    //encrypt vote and save it to database
                    //Use CurrentTime + CandidateName +Candidate Id to des encrypt it


                    //get CandidateName and Id
                    //encrypt it and put it in votingTable


                    User.HasVotedForCandidate = true;
                    await _userManager.UpdateAsync(User);
                    return true;
                }

            }

            return false;
        }


        public async Task<bool> RegisterUserForVotingAsync()
        {
            var CurrentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var User = _userManager.Users.Where(_ => _.Id == CurrentUserId).FirstOrDefault();
            if (User != null)
            {
                User.IsRegisteredForElection = true;
                await _userManager.UpdateAsync(User);
                return true;
            }
            //set is registered to vote to true

            return false;
        }


        public List<BBCountingPhase> GetAllEncryptedVotes()
        {
            var votes = from vote in _votesRepo.List().ToList()
                        select new BBCountingPhase
                        {
                            EncryptedUsernameVotedCandidate = vote.CandidateName
                        };

            return votes.ToList();
        }

        public List<BBCountingPhase> GetAllDecryptedVotes()
        {
            var votes = from vote in _decryptedVotesRepo.List().ToList()
                        select new BBCountingPhase
                        {
                            EncryptedUsernameVotedCandidate = vote.DecryptedVote
                        };

            return votes.ToList();
        }

        public bool DecryptAndDisplayAllVotesToPlainText()
        {
            //get from votes, decrypt and save,
            //decrypt and save
            //thats all
            var Votes = _votesRepo.List().ToList();


            foreach(var vote in Votes)
            {
                var decryptedVote = new DecryptedVotes
                {
                    DecryptedVote = _desService.Decrypt(vote.CandidateName, "Musa")
              };

            _decryptedVotesRepo.Insert(decryptedVote);
            }

            return true;
        }







    }



    public class BBCountingPhase
    {
        public string EncryptedUsernameVotedCandidate { get; set; }
        public string DecryptedUsernameVotedCandidate { get; set; }
        public string UserName { get; set; }
        public string CandidateVotedForId { get; set; }
        public string CandidateVotedForName { get; set; }
    }
    public class BBRegistrationPhase
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    public class BBVotingPhase
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class ElectionStage
    {
        public long Id { get; set; }
        public string StageName { get; set; }
        public bool IsCurrentStage { get; set; }

        public int Status { get; set; }

        //1 Complete
        //2 in progress
        //0 has not began


    }
}
