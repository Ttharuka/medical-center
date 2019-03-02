using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medcs.Models
{
    public partial class RoleCarryOuts
    {
        public int Id { get; set; }
        [DisplayName("Role Group")]
        public int RoleGroupId { get; set; }
        [DisplayName("Role")]
        public int RoleId { get; set; }

        public Roles Role { get; set; }
        public RoleGroups RoleGroup { get; set; }
    }
}
