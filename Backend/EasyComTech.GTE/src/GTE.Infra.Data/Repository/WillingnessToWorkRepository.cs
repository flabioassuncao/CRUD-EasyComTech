using GTE.Domain.Entities;
using GTE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Infra.Data.Context;

namespace GTE.Infra.Data.Repository
{
    public class WillingnessToWorkRepository : Repository<WillingnessToWork>, IWillingnessToWorkRepository
    {
        public WillingnessToWorkRepository(GTEContext context) : base(context)
        {
        }
    }
}
