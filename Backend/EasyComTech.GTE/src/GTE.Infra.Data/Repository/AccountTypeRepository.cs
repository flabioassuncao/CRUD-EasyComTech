using GTE.Domain.Entities;
using GTE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Infra.Data.Context;

namespace GTE.Infra.Data.Repository
{
    public class AccountTypeRepository : Repository<AccountType>, IAccountTypeRepository
    {
        public AccountTypeRepository(GTEContext context) : base(context)
        {
        }
    }
}
