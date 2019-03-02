using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medcs.Models
{
    public partial class Doctors
    {
        public Doctors()
        {
            Appointments = new HashSet<Appointments>();
            Sessions = new HashSet<Sessions>();
            Settlements = new HashSet<Settlements>();
        }

        public int Id { get; set; }
        [DisplayName("User")]
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public string RegistrationNumber { get; set; }
        public string Hospital { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }

        public Users User { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Sessions> Sessions { get; set; }
        public ICollection<Settlements> Settlements { get; set; }
    }
}
