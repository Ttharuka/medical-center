using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medcs.Models
{
    public partial class Users
    {

        //Hashset for not duplicate a set
        public Users()
        {
            Appointments = new HashSet<Appointments>();
            Doctors = new HashSet<Doctors>();
            Inventories = new HashSet<Inventories>();
            Notifications = new HashSet<Notifications>();
            Patients = new HashSet<Patients>();
            UserRoleGroups = new HashSet<UserRoleGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
        public int? ClinicId { get; set; }
        public string VerificationCode { get; set; }

        public Clinics Clinic { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Doctors> Doctors { get; set; }
        public ICollection<Inventories> Inventories { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<Patients> Patients { get; set; }
        public ICollection<UserRoleGroups> UserRoleGroups { get; set; }

        [NotMapped]
        public string Token { get; internal set; }

    }
}
