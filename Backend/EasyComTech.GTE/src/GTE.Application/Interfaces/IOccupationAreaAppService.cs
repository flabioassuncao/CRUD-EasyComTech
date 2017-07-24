using GTE.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.Interfaces
{
    public interface IOccupationAreaAppService : IDisposable
    {
        OccupationAreaViewModel GetByIdProgrammer(Guid id);
    }
}
