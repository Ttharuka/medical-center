using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medcs.Models
{
    public partial class Appointments
    {
        public Appointments()
        {
            Payments = new HashSet<Payments>();
            Prescriptions = new HashSet<Prescriptions>();
        }

        public int Id { get; set; }
        [DisplayName("Clinic")]
        public int ClinicId { get; set; }
        [Required(ErrorMessage = "You must provide a Clinics")]
        [DisplayName("Patient")]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "You must provide a Patient")]
        [DisplayName("Doctor")]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "You must provide a Doctor")]
        public int SessionId { get; set; }
        public DateTime AppointedAt { get; set; }
        public byte IsPresent { get; set; }
        public int? CreatedBy { get; set; }
        public string Diagnosis { get; set; }

        public Clinics Clinic { get; set; }
        [DisplayName("Create User")]
        public Users CreatedByNavigation { get; set; }
        public Doctors Doctor { get; set; }
        public Patients Patient { get; set; }
        public Sessions Session { get; set; }
        public ICollection<Payments> Payments { get; set; }
        public ICollection<Prescriptions> Prescriptions { get; set; }
    }
}
