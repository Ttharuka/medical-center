using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medcs.Models
{
    public partial class Clinics
    {
        public Clinics()
        {
            Appointments = new HashSet<Appointments>();
            Inventories = new HashSet<Inventories>();
            Sessions = new HashSet<Sessions>();
            Settlements = new HashSet<Settlements>();
            SubscriptionInvoices = new HashSet<SubscriptionInvoices>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide a Register Number")]
        [DisplayName("Registration Number")]
        public string RegNo { get; set; }
        [Required(ErrorMessage = "You must provide a Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime SubscribedAt { get; set; }
        public string BillingCycle { get; set; }
        public byte IsActive { get; set; }

        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Inventories> Inventories { get; set; }
        public ICollection<Sessions> Sessions { get; set; }
        public ICollection<Settlements> Settlements { get; set; }
        public ICollection<SubscriptionInvoices> SubscriptionInvoices { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
