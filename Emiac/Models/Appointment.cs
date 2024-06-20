using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class Appointment
    {

        public int? IdAppointments { get; set; }
        public long Oms { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public int? StatusId { get; set; }

        public virtual Doctor Doctor { get; set; } = null!;
        public virtual Patient OmsNavigation { get; set; } = null!;
        public virtual Status? Status { get; set; }

    }
}
