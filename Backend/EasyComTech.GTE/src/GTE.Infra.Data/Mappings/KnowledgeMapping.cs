using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GTE.Infra.Data.Mappings
{
    public class KnowledgeMapping : EntityTypeConfiguration<Knowledge>
    {
        public override void Map(EntityTypeBuilder<Knowledge> builder)
        {
            builder.ToTable("Knowledge");

            builder.HasKey(c => c.Id);

            builder.HasOne(e => e.Programmer)
                .WithOne(e => e.Knowledge)
                .HasForeignKey<Programmer>(c => c.KnowledgeId);
        }
    }
}
