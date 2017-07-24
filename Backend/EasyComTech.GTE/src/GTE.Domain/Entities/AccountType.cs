using System;
using System.Collections.Generic;

namespace GTE.Domain.Entities
{
    public class AccountType
    {
        public AccountType()
        {
            Id = Guid.NewGuid();
            BankInformation = new List<BankInformation>();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<BankInformation> BankInformation { get; set; }
    }
}
