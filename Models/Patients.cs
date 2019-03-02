﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medcs.Models
{
    public partial class Patients
    {
        public Patients()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int Id { get; set; }
        [DisplayName("User")]
        public int UserId { get; set; }
        public string Nic { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string BloodGroup { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactAddress { get; set; }
        public string Notes { get; set; }

        public Users User { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
    }
}
