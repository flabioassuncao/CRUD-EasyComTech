using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Entities
{
    public class OccupationArea
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string Linkedin { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portfolio { get; set; }

        public Guid WillingnessToWorkId { get; set; }
        public WillingnessToWork WillingnessToWork { get; set; }

        public Guid BestTimeToWorkId { get; set; }
        public BestTimeToWork BestTimeToWork { get; set; }
        
        public decimal HourlySalaryRequirements { get; set; }


    }
}
