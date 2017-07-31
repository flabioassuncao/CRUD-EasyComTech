using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.ViewModels
{
    public class ProgrammerViewModel
    {
        public ProgrammerViewModel()
        {
            Id = Guid.NewGuid();
            Excluded = false;
        }

        public Guid Id { get; set; }

        public string Email { get; set; }

        public bool? Excluded { get; set; }

        public Guid OccupationAreaId { get; set; }
        public OccupationAreaViewModel OccupationArea { get; set; }

        public Guid BankInformationId { get; set; }
        public BankInformationViewModel BankInformation { get; set; }

        public Guid KnowledgeId { get; set; }
        public KnowledgeViewModel Knowledge { get; set; }
    }
}
