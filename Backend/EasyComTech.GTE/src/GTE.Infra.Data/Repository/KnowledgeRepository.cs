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
    public class KnowledgeRepository : Repository<Knowledge>, IKnowledgeRepository
    {
        public KnowledgeRepository(GTEContext context) : base(context)
        {
        }

        public Knowledge GetByIdProgrammer(Guid id)
        {
            var sql = $"SELECT * FROM Knowledge k " +
                     $"WHERE k.ProgrammerId = @uprogrammerId";

            var occupationArea = Db.Database.GetDbConnection().Query<Knowledge>(sql, new { uprogrammerId = id });

            return occupationArea.FirstOrDefault();
        }
    }
}
