using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VotingSystemWeb.Models;
using Vs.Core.Votes;
using Vs.Data.Repository;
using Vs.Services.CandidatesServices;
using Vs.Services.StateServices;
using Vs.Services.UserServices;

namespace VotingSystemWeb.Controllers
{
    public class SessionController : Controller
    {
        private readonly ICandidatesService _candidatesService;
        private readonly IStateService _stateService;
        private readonly IUsersService _userService;

        public SessionController(ICandidatesService candidatesService, IStateService stateService, IUsersService userService)
        {
            _candidatesService = candidatesService;
            _stateService = stateService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            bool isAuthenticated = User.Identity.IsAuthenticated;
            bool role = User.IsInRole("Administrator");
            if (!isAuthenticated)
            {
                return RedirectToAction("Index","Home");
                //redirect to login page


          
            }

            var RegistrationPhase = new SessionRegistrationPhase
            {
                RegistrationSessionBegan = _stateService.ResolveRegistrationPhaseHasBegan(),

                HasAgreedToTermsAndConditions = _userService.HasUserAgreedToTermsAndConditions(),
                IsRegisteredForElection = _userService.IsUserRegisteredForElection(),


                RegistrationHasEnded = _stateService.ResolveRegistrationPhaseHasEnded(),
                

            };


            var VotingPhase = new SessionVotingPhase
            {

                VotingHasBegan = _stateService.ResolveVotingPhaseHasBegan(),


                UserHasVotedForCandidate = _userService.HasUserVotedForCandidate(),

                VotingSessionHasEnded = _stateService.ResolveVotingPhaseHasEnded(),
                
            };


            var CandidatesList = _candidatesService.GetAllCandidates();


            return View(new SessionVM
            {
                CandidatesList= CandidatesList,
                VotingPhase = VotingPhase,
                RegistrationPhase = RegistrationPhase

            });
        }


        public async Task<IActionResult> RegisterForVotingAsync()
        {
            await _stateService.RegisterUserForVotingAsync();
            return RedirectToAction("index", "Session");
        }

        public async Task<IActionResult> VoteForCandidateAsync(long CandidateId)
        {
           await _stateService.VoteForCandidateAsync(CandidateId);
            return RedirectToAction("index", "Session");
        }


    }

   
}