using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vs.Services.CandidatesServices;

namespace VotingSystemWeb.Models
{
    public class SessionVM
    {
       public  SessionVotingPhase VotingPhase { get; set; }
        public SessionRegistrationPhase RegistrationPhase { get; set; }
        public List<Candidatesvm> CandidatesList { get; set; }
    }


    public class SessionVotingPhase
    {
       
        
        public bool VotingHasBegan { get; set; }
        public bool VotingSessionHasEnded { get; set; }
        public bool UserHasVotedForCandidate { get; set; }

    }

    public class SessionRegistrationPhase
    {
        public bool IsRegisteredForElection { get; set; }
        public bool RegistrationHasEnded { get; set; }

        public bool RegistrationSessionBegan { get; set; } = false;
        public bool HasAgreedToTermsAndConditions { get; set; }


    }
}
