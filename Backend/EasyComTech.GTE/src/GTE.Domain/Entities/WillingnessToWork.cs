using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Entities
{
    public class WillingnessToWork
    {
        public WillingnessToWork()
        {
            Id = Guid.NewGuid();
            OccupationArea = new List<OccupationArea>();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<OccupationArea> OccupationArea { get; set; }
    }
}
