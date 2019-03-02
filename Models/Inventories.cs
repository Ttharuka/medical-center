using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medcs.Models
{
    public partial class Inventories
    {
        public Inventories()
        {
            Prescriptions = new HashSet<Prescriptions>();
        }

        public int Id { get; set; }
        [DisplayName("Clinic")]
        public int? ClinicId { get; set; }
        [DisplayName("Added User")]
        public int? AddedBy { get; set; }
        [DisplayName("Generic Name")]
        public string GenericName { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Expiry Date")]
        public DateTime ExpiryDate { get; set; }
        [DisplayName("Storage Temperature")]
        public string StorageTemperature { get; set; }
        public string Manufacturer { get; set; }
        public string Strength { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Batch Number")]
        public int BatchNo { get; set; }
        [DisplayName("Record Level")]
        public int ReorderLevel { get; set; }
        [DisplayName("Manufactured Date")]
        public DateTime ManufacturedDate { get; set; }
        public string Notes { get; set; }

        public Users AddedByNavigation { get; set; }
        public Clinics Clinic { get; set; }
        public ICollection<Prescriptions> Prescriptions { get; set; }
    }
}
