using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GTE.Infra.Data.Mappings
{
    public class BankInformationMapping : EntityTypeConfiguration<BankInformation>
    {
        public override void Map(EntityTypeBuilder<BankInformation> builder)
        {
            builder.ToTable("BankInformation");

            builder.HasKey(c => c.Id);

            builder.HasOne(e => e.Programmer)
                .WithOne(e => e.BankInformation)
            .HasForeignKey<Programmer>(c => c.BankInformationId);

            builder.HasOne(e => e.AccountType)
                .WithMany(e => e.BankInformation)
                .HasForeignKey(e => e.AccountTypeId)
                .IsRequired(true);

            
        }
    }
}
