using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vs.Services.CandidatesServices;
using Vs.Services.StateServices;

namespace VotingSystemWeb.Models
{
    public class CentralGovernmentVm
    {
        public List<Candidatesvm> CandidatesList { get; set; }
        public List<ElectionStage> ElectionStages { get; set; }
    }






    
}
