using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.ViewModels
{
    public class OccupationAreaViewModel
    {
        public OccupationAreaViewModel()
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
        public WillingnessToWorkViewModel WillingnessToWork { get; set; }

        public Guid BestTimeToWorkId { get; set; }
        public BestTimeToWorkViewModel BestTimeToWork { get; set; }

        public decimal HourlySalaryRequirements { get; set; }


        public Guid ProgrammerId { get; set; }
        public ProgrammerViewModel Programmer { get; set; }
    }
}
