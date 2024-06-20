using System;
using System.Collections.Generic;

namespace Emiac.Models
{
    public partial class Admin
    {
        public int? IdAdmin { get; set; }
        public string Surname { get; set; } = null!;
        public string NameAdmin { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string EnterPassword { get; set; } = null!;
    }
}
