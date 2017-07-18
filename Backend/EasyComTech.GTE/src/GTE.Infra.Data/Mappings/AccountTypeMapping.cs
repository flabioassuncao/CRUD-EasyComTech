using GTE.Domain.Entities;
using GTE.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GTE.Infra.Data.Mappings
{
    public class AccountTypeMapping : EntityTypeConfiguration<AccountType>
    {
        public override void Map(EntityTypeBuilder<AccountType> builder)
        {
            builder.ToTable("AccountType");

            builder.HasKey(c => c.Id);
        }
    }
}
