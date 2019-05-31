
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vs.Core.Users
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime LastLoginDateUtc { get; set; }

        public bool Flag { get; set; }
        public string CitizenNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool HasAgreedToTermsAndConditions { get; set; }

        public bool IsRegisteredForElection { get; set; }

        public bool HasVotedForCandidate { get; set; }
    }
}
