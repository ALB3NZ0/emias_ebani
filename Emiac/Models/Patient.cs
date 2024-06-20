using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class Patient
    {

        public long Oms { get; set; }
        public string Surname { get; set; } = null!;
        public string NamePatient { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string AddressPatient { get; set; } = null!;
        public string LivingAddress { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Nickname { get; set; } = null!;
    }
}
