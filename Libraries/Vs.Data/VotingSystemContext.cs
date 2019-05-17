using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vs.Core;
using Vs.Data.Mappings;

namespace Vs.Data
{
    public class VotingSystemContext : DbContext
    {
        public VotingSystemContext( DbContextOptions<VotingSystemContext> options) : base(options)
        {
        }


        public virtual DbSet<SampleTable> SampleTable{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SampleTableMap());

        }

        }
    }
