using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class ResearchDocument
    {
        public int? IdResearchDocument { get; set; }
        public string Rtf { get; set; } = null!;
        public byte[]? Attachment { get; set; }
        public int AppointmentsId { get; set; }

        public virtual Appointment Appointments { get; set; } = null!;
    }
}
