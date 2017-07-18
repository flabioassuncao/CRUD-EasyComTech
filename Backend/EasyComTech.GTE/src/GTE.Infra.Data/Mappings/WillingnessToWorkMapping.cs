using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GTE.Infra.Data.Mappings
{
    public class WillingnessToWorkMapping : EntityTypeConfiguration<WillingnessToWork>
    {
        public override void Map(EntityTypeBuilder<WillingnessToWork> builder)
        {
            builder.ToTable("WillingnessToWork");

            builder.HasKey(c => c.Id);
            
        }
    }
}
