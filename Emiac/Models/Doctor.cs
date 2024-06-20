using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class Doctor
    {

        public int? IdDoctor { get; set; }
        public string Surname { get; set; } = null!;
        public string NameDoctor { get; set; } = null!;
        public string? Patronymic { get; set; }
        public int SpecialityId { get; set; }
        public string EnterPassword { get; set; } = null!;
        public string WorkAddress { get; set; } = null!;

        public virtual Specialite Speciality { get; set; } = null!;
    }
}
