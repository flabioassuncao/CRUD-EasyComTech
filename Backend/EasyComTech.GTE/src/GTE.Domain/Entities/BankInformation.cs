using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Entities
{
    public class BankInformation
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Bank { get; set; }

        public string Agency { get; set; }

        public Guid AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }

        public string AccountNumber { get; set; }
    }
}