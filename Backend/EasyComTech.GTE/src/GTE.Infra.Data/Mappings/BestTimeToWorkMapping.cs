using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GTE.Infra.Data.Mappings
{
    public class BestTimeToWorkMapping : EntityTypeConfiguration<BestTimeToWork>
    {
        public override void Map(EntityTypeBuilder<BestTimeToWork> builder)
        {
            builder.ToTable("BestTimeToWork");

            builder.HasKey(c => c.Id);
        }
    }
}
