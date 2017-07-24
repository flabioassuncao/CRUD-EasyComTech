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
    public class OccupationAreaRepository : Repository<OccupationArea>, IOccupationAreaRepository
    {
        public OccupationAreaRepository(GTEContext context) : base(context)
        {
        }

        public OccupationArea GetByIdProgrammer(Guid id)
        {
            var sql = $"SELECT * FROM OccupationArea oa " +
                      $"left join WillingnessToWork wt " +
                      $"on oa.WillingnessToWorkId = wt.Id " +
                      $"left join BestTimeToWork bt " +
                      $"on oa.BestTimeToWorkId = bt.Id " +
                     $"WHERE oa.ProgrammerId = @uprogrammerId";

            var occupationArea = Db.Database.GetDbConnection().Query<OccupationArea, WillingnessToWork, BestTimeToWork, OccupationArea>(sql,
                (oa, wt, bt) =>
                {
                    if (wt != null)
                        oa.WillingnessToWork = wt;

                    if (bt != null)
                        oa.BestTimeToWork = bt;

                    return oa;

                },new { uprogrammerId = id });

            return occupationArea.FirstOrDefault();
        }
    }
}
