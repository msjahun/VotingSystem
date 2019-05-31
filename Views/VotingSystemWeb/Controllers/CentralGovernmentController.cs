using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VotingSystemWeb.Models;
using Vs.Services.CandidatesServices;
using Vs.Services.StateServices;

namespace VotingSystemWeb.Controllers
{
    public class CentralGovernmentController : Controller
    {
        private readonly IStateService _stateService;
        private readonly ICandidatesService _candidatesService;

        public CentralGovernmentController(IStateService stateService, ICandidatesService candidatesService)
        {
            _stateService = stateService;
            _candidatesService = candidatesService;
        }

        public IActionResult Index()
        {

            var model = new CentralGovernmentVm
            {
                CandidatesList = _candidatesService.GetAllCandidates(),

            ElectionStages = _stateService.GetAllStates()



            };

            return View(model);
        }


        public IActionResult GoToNextState()
        {
            _stateService.GoToNextState();

            return RedirectToAction("index", "CentralGovernment");
        }


        public async Task<IActionResult> ResetStates()
        {
           await _stateService.ResetStateAsync();

            return RedirectToAction("index", "CentralGovernment");
        }


        public IActionResult DecryptAllVotes()
        {
            _stateService.DecryptAndDisplayAllVotesToPlainText();
            return RedirectToAction("index", "CentralGovernment");
        }
    }
}