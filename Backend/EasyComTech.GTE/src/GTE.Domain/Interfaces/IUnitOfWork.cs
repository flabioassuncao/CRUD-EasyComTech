using GTE.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
