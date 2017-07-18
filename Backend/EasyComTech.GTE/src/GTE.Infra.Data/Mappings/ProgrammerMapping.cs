using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GTE.Infra.Data.Mappings
{
    public class ProgrammerMapping : EntityTypeConfiguration<Programmer>
    {
        public override void Map(EntityTypeBuilder<Programmer> builder)
        {
            builder.ToTable("Programmer");
            builder.HasKey(c => c.Id);

            //builder.HasOne(e => e.OccupationArea)
            //    .WithOne(e => e.Programmer)
            //    .HasForeignKey<OccupationArea>(c => c.ProgrammerId);
            ////    .IsRequired(true);

            //builder.HasOne(e => e.BankInformation)
            //    .WithOne(e => e.Programmer)
            //.HasForeignKey<BankInformation>(c => c.ProgrammerId);
            ////.IsRequired(true);

            //builder.HasOne(e => e.Knowledge)
            //    .WithOne(e => e.Programmer)
            //    .HasForeignKey<Knowledge>(c => c.ProgrammerId);
            //    //.IsRequired(true);
        }
    }
}
