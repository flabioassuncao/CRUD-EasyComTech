using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.ViewModels
{
    public class WillingnessToWorkViewModel
    {
        public WillingnessToWorkViewModel()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public ICollection<OccupationAreaViewModel> OccupationArea { get; set; }
    }
}
