using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VotingSystemWeb.Models;
using Vs.Services.StateServices;

namespace VotingSystemWeb.Controllers
{
    public class BulletinBoardController : Controller
    {
        private readonly IStateService _stateService;

        public BulletinBoardController(IStateService stateService)
        {
            _stateService = stateService;
        }

        public IActionResult Index()
        {


            BulletinBoardVm model = new BulletinBoardVm
            {
                bBProxyPhaseList = new List<BBProxyPhase>
                {
                    new BBProxyPhase
                    {
                        ProxyId = Guid.NewGuid(),
                        ProxyName = "Local government 1"


                    }
                },

                bBRegistrationPhaseList = _stateService.GetAllUsersWhoHaveRegisteredForElection(),

                bBVotingPhaseList = _stateService.GetAllUsersWhoHaveValidVotes(),

                bBCountingPhaseList = _stateService.GetAllEncryptedVotes(),
                bBCountingPhaseList2 = _stateService.GetAllDecryptedVotes(),

                //bBCandidatesNoVotesList = new List<BBCandidatesNoVotes>
                //{
                //    new BBCandidatesNoVotes
                //    {
                //        CandidateName="Jon snow",
                //        NumberOfVotes= 234
                //    },

                //      new BBCandidatesNoVotes
                //    {
                //        CandidateName="Arya stark",
                //        NumberOfVotes= 22
                //    },

                //        new BBCandidatesNoVotes
                //    {
                //        CandidateName="Jisoo blackpink",
                //        NumberOfVotes= 98
                //    },
                //},

                //bBVotingParticipantsSummary= new BBVotingParticipantsSummary
                //{
                //    NumberOfPeoleWhoDidntVote= 23,
                //    NumberOfPeopleWhoVoted=34,
                //    NumberOfRegisteredVoters=14
                //}

            };

            
            return View(model);
        }
    }
}