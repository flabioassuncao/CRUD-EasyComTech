using GTE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Interfaces
{
    public interface IOccupationAreaRepository : IRepository<OccupationArea>
    {
        OccupationArea GetByIdProgrammer(Guid id);
    }
}
