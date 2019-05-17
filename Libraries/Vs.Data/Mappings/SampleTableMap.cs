using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vs.Core;

namespace Vs.Data.Mappings
{
    class SampleTableMap : IEntityTypeConfiguration<SampleTable>
    {
        public void Configure(EntityTypeBuilder<SampleTable> builder)
        {


        

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Age).HasColumnName("Age");
        }
    }
}
