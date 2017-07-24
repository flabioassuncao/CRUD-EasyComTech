using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Entities
{
    public class OccupationArea
    {
        public OccupationArea()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string Linkedin { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portfolio { get; set; }

        public Guid WillingnessToWorkId { get; set; }
        public virtual WillingnessToWork WillingnessToWork { get; set; }

        public Guid BestTimeToWorkId { get; set; }
        public virtual BestTimeToWork BestTimeToWork { get; set; }
        
        public decimal HourlySalaryRequirements { get; set; }
        
        public Guid? ProgrammerId { get; set; }
        public virtual Programmer Programmer { get; set; }
    }
}
