using GTE.Domain.Entities;
using GTE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Dapper;
using System.Linq;

namespace GTE.Infra.Data.Repository
{
    public class BankInformationRepository : Repository<BankInformation>, IBankInformationRepository
    {
        public BankInformationRepository(GTEContext context) : base(context)
        {
        }

        public BankInformation GetByIdProgrammer(Guid id)
        {
            var sql = $"SELECT * FROM BankInformation bi " +
                     $"left join AccountType at " +
                     $"on bi.AccountTypeId = at.Id " +
                     $"WHERE bi.ProgrammerId = @uprogrammerId";

            var occupationArea = Db.Database.GetDbConnection().Query<BankInformation, AccountType, BankInformation>(sql,
                (bi, at) =>
                {
                    if (at != null)
                        bi.AccountType = at;

                    return bi;
                }, new { uprogrammerId = id });

            return occupationArea.FirstOrDefault();
        }
    }
}
