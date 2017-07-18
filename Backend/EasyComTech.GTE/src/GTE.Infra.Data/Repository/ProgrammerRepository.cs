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
    public class ProgrammerRepository : Repository<Programmer>, IProgrammerRepository
    {
        public ProgrammerRepository(GTEContext context) : base(context)
        {
        }


        public override Programmer GetById(Guid id)
        {
            var sql = @"SELECT * FROM Programmer P " +
                      "LEFT JOIN OccupationArea o " +
                      "ON p.Id = o.ProgrammerId " +
                      "LEFT JOIN bankInformation bi " +
                      "ON p.Id = bi.ProgrammerId " +
                      "LEFT JOIN knowledge k " +
                      "ON p.Id = k.ProgrammerId " +
                        "WHERE P.Excluded = 0 " +
                        "AND P.Id = @uid";

            var programmer = Db.Database.GetDbConnection().Query<Programmer, OccupationArea, BankInformation, Knowledge, Programmer>(sql,
                (p, oa, bi, k) =>
                {
                    if (oa != null)
                        p.OccupationArea = oa;

                    if (bi != null)
                        p.BankInformation = bi;

                    if (k != null)
                        p.Knowledge = k;

                    return p;
                }, new { uid = id });

            return programmer.FirstOrDefault();
        }


        public override IEnumerable<Programmer> GetAll()
        {
            var sql = @"SELECT * FROM Programmer P " +
                      "LEFT JOIN OccupationArea o " +
                      "ON p.Id = o.ProgrammerId " +
                      "LEFT JOIN bankInformation bi " +
                      "ON p.Id = bi.ProgrammerId " +
                      "LEFT JOIN knowledge k " +
                      "ON p.Id = k.ProgrammerId " +
                        "WHERE P.Excluded = 0";

            var programmer = Db.Database.GetDbConnection().Query<Programmer, OccupationArea, BankInformation, Knowledge, Programmer>(sql,
                (p, oa, bi, k) =>
                {
                    if (oa != null)
                        p.OccupationArea = oa;

                    if (bi != null)
                        p.BankInformation = bi;

                    if (k != null)
                        p.Knowledge = k;

                    return p;
                });

            return programmer.ToList();
        }

        public override void Remove(Guid id)
        {
            var programmer = base.GetById(id);
            programmer.Excluded = true;
            
            base.Update(programmer);
        }

        public void AddBankInformation(BankInformation bank)
        {
            Db.BankInformation.Add(bank);
        }

        public void AddKnowledge(Knowledge knowledge)
        {
            Db.Knowledge.Add(knowledge);
        }

        public void AddOccupationArea(OccupationArea area)
        {
            Db.OccupationArea.Add(area);
        }

        public void UpdateBankInformation(BankInformation bank)
        {
            Db.BankInformation.Update(bank);
        }

        public void UpdateKnowledge(Knowledge knowledge)
        {
            Db.Knowledge.Update(knowledge);
        }

        public void UpdateOccupationArea(OccupationArea area)
        {
            Db.OccupationArea.Update(area);
        }
    }
}
