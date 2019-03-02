using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medcs.Models
{
    public partial class UserRoleGroups
    {
        public int Id { get; set; }
        [DisplayName("User")]
        public int UserId { get; set; }
        [DisplayName("Role Group")]
        public int RoleGroupId { get; set; }

        public RoleGroups RoleGroup { get; set; }
        public Users User { get; set; }
    }
}
