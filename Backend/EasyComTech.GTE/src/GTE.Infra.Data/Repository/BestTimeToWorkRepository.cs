using GTE.Domain.Entities;
using GTE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Infra.Data.Context;

namespace GTE.Infra.Data.Repository
{
    public class BestTimeToWorkRepository : Repository<BestTimeToWork>, IBestTimeToWorkRepository
    {
        public BestTimeToWorkRepository(GTEContext context) : base(context)
        {
        }
    }
}
