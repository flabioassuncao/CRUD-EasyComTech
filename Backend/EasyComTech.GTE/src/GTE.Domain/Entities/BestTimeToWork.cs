﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Entities
{
    public class BestTimeToWork
    {
        public BestTimeToWork()
        {
            Id = new Guid();
            OccupationArea = new List<OccupationArea>();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<OccupationArea> OccupationArea { get; set; }
    }
}
