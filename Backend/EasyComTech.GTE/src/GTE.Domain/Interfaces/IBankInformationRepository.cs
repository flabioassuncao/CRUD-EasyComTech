using GTE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Interfaces
{
    public interface IBankInformationRepository : IRepository<BankInformation>
    {
        BankInformation GetByIdProgrammer(Guid id);
    }
}
