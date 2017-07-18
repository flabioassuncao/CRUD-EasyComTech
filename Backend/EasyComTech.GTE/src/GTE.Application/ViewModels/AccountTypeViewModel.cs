using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.ViewModels
{
    public class AccountTypeViewModel
    {
        public AccountTypeViewModel()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public ICollection<BankInformationViewModel> BankInformation { get; set; }
    }
}
