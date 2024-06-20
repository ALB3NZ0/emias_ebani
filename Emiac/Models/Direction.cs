using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class Direction
    {
        public int? IdDirection { get; set; }
        public int SpecialityId { get; set; }
        public long OmsId { get; set; }

        public virtual Patient Oms { get; set; } = null!;
        public virtual Specialite Speciality { get; set; } = null!;
    }
}
