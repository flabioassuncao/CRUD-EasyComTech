using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.ViewModels
{
    public class BankInformationViewModel
    {
        public BankInformationViewModel()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Bank { get; set; }

        public string Agency { get; set; }

        public Guid AccountTypeId { get; set; }
        public AccountTypeViewModel AccountType { get; set; }

        public string AccountNumber { get; set; }


        public Guid ProgrammerId { get; set; }
        public ProgrammerViewModel Programmer { get; set; }
    }
}
