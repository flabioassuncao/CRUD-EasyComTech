using GTE.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.Interfaces
{
    public interface IProgrammerAppService : IDisposable
    {
        ProgrammerViewModel AddProgrammer(ProgrammerViewModel programmer);

        List<ProgrammerViewModel> GetAllProgrammers();

        ProgrammerViewModel GetById(Guid id);

        void UpdateProgramer(ProgrammerViewModel programmer);

        void Remove(Guid id);
    }
}
