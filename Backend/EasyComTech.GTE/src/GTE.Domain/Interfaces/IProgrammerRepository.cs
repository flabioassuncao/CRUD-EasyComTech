using GTE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Interfaces
{
    public interface IProgrammerRepository : IRepository<Programmer>
    {
        void AddOccupationArea(OccupationArea area);
        void UpdateOccupationArea(OccupationArea area);

        void AddBankInformation(BankInformation bank);
        void UpdateBankInformation(BankInformation bank);

        void AddKnowledge(Knowledge knowledge);
        void UpdateKnowledge(Knowledge knowledge);
    }
}
