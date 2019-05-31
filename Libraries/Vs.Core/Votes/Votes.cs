using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Core.Votes
{
    public class Votes:BaseEntity
    {

        public string VoteGuid { get; set; }
        public string CandidateName { get; set; }
    }


    public class DecryptedVotes : BaseEntity
    {

        
        public string DecryptedVote { get; set; }
    }
}
