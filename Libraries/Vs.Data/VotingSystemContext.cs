using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vs.Core;
using Vs.Core.Candidates;
using Vs.Core.ElectionState;
using Vs.Core.Users;
using Vs.Core.Votes;
using Vs.Data.Mappings;

namespace Vs.Data
{
    public class VotingSystemContext : IdentityDbContext<ApplicationUser>
    {
        public VotingSystemContext( DbContextOptions<VotingSystemContext> options) : base(options)
        {
        }


        public virtual DbSet<SampleTable> SampleTable{ get; set; }
        public virtual DbSet<ElectionStates> ElectionStates { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<Votes> Votes { get; set; }
        public virtual DbSet<DecryptedVotes> DecryptedVotes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SampleTableMap());

        }

        }
    }
