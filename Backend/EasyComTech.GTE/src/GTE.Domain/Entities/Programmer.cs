using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Entities
{
    public class Programmer
    {
        public Programmer()
        {
            Id = Guid.NewGuid();
            Excluded = false;
        }

        public Guid Id { get; set; }

        public string Email { get; set; }

        public bool Excluded { get; set; }

        public Guid OccupationAreaId { get; set; }
        public virtual OccupationArea OccupationArea { get; set; }

        public Guid BankInformationId { get; set; }
        public virtual BankInformation BankInformation { get; set; }

        public Guid KnowledgeId { get; set; }
        public virtual Knowledge Knowledge { get; set; }
    }
}
