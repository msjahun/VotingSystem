using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vs.Services.StateServices;

namespace VotingSystemWeb.Models
{
    public class BulletinBoardVm
    {
        public List<BBProxyPhase> bBProxyPhaseList { get; set; }
        public List<BBRegistrationPhase> bBRegistrationPhaseList { get; set; }

        public List<BBVotingPhase> bBVotingPhaseList { get; set; }
        public List<BBCountingPhase> bBCountingPhaseList { get; set; }
        public List<BBCountingPhase> bBCountingPhaseList2 { get; set; }

        public List<BBCandidatesNoVotes> bBCandidatesNoVotesList { get; set; }

        public BBVotingParticipantsSummary bBVotingParticipantsSummary { get; set; }



    }

    public class BBProxyPhase
    {
        public Guid ProxyId { get; set; }
        public string ProxyName { get; set; }
    }


    

    
    public class BBCandidatesNoVotes
    {
        public string CandidateName { get; set; }
        public int NumberOfVotes { get; set; }
       
    }

    public class BBVotingParticipantsSummary
    {
        public int NumberOfRegisteredVoters { get; set; }
        public int NumberOfPeopleWhoVoted { get; set; }

        public int NumberOfPeoleWhoDidntVote { get; set; }

    }



}
