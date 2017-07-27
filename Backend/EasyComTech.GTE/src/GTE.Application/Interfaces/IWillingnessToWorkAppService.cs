using GTE.Application.ViewModels;
using GTE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.Interfaces
{
    public interface IWillingnessToWorkAppService : IDisposable
    {
        List<WillingnessToWorkViewModel> GetAll();
    }
}
