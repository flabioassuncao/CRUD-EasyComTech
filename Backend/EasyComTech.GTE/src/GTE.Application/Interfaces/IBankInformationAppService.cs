using GTE.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.Interfaces
{
    public interface IBankInformationAppService : IDisposable
    {
        BankInformationViewModel GetByIdProgrammer(Guid id);
    }
}
