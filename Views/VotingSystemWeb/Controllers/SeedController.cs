using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vs.Core.Candidates;
using Vs.Core.ElectionState;
using Vs.Data.Repository;

namespace VotingSystemWeb.Controllers
{
    public class SeedController : Controller
    {
        private readonly IRepository<ElectionStates> _statesRepo;
        private readonly IRepository<Candidates> _candidatesRepo;

        public SeedController(IRepository<ElectionStates> StatesRepo, IRepository<Candidates> CandidatesRepo)
        {

            _statesRepo = StatesRepo;
            _candidatesRepo = CandidatesRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedStates()
        {
            var states = new List<ElectionStates>()
            {
                new ElectionStates
                {
                    StateName="Proxy state",
                    IsCurrentState= false,
                    Status= StateEnum.Default
                },

                  new ElectionStates
                {
                    StateName="Registration state",
                    IsCurrentState= false,
                    Status= StateEnum.Default
                },

                    new ElectionStates
                {
                    StateName="Voting state",
                    IsCurrentState= false,
                    Status= StateEnum.Default
                },

                      new ElectionStates
                {
                    StateName="Counting state",
                    IsCurrentState= false,
                    Status= StateEnum.Default
                },


            };

            foreach(var state in states)
            {
                _statesRepo.Insert(state);
            }
            
            return Json(true);
        }


        public IActionResult SeedCandidates()
        {
            var Candidates = new List<Candidates>()
            {
                new Candidates
                {
                    Name="Jon Snow"
                },

                 new Candidates
                {
                    Name="Arya Stark"
                },

                  new Candidates
                {
                    Name="Brandon stark"
                },
                   new Candidates
                {
                    Name="Night King"
                }
            };

            foreach(var candidate in Candidates)
            {
                _candidatesRepo.Insert(candidate);
            }

            return Json(true);
        }
    }
}