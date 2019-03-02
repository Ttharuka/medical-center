using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medcs.Models
{
    public class PatientUser
    {
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }

        //[Range(9,12)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})[-. ]?([v||X]{1})$", ErrorMessage = "Not a valid NIC")]
        public string Nic { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
    }
}
