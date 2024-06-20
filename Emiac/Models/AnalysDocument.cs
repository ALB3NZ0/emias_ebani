using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class AnalysDocument
    {
        public int? IdAnalysDocument { get; set; }
        public string Rtf { get; set; } = null!;
        public int AppointmentsId { get; set; }

        public virtual Appointment Appointments { get; set; } = null!;
    }
}
