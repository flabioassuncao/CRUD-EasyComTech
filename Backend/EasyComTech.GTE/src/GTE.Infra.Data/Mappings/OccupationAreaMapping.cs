using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GTE.Infra.Data.Mappings
{
    public class OccupationAreaMapping : EntityTypeConfiguration<OccupationArea>
    {
        public override void Map(EntityTypeBuilder<OccupationArea> builder)
        {
            builder.ToTable("OccupationArea");

            builder.HasKey(c => c.Id);

            builder.HasOne(e => e.Programmer)
                .WithOne(e => e.OccupationArea)
                .HasForeignKey<Programmer>(c => c.OccupationAreaId);
            //.IsRequired(true);

            builder.HasOne(e => e.WillingnessToWork)
                .WithMany(e => e.OccupationArea)
                .HasForeignKey(e => e.WillingnessToWorkId)
                .IsRequired(true);

            builder.HasOne(e => e.BestTimeToWork)
                .WithMany(e => e.OccupationArea)
                .HasForeignKey(e => e.BestTimeToWorkId)
                .IsRequired(true);
        }
    }
}
