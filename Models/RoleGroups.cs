using System;
using System.Collections.Generic;

namespace Medcs.Models
{
    public partial class RoleGroups
    {
        public RoleGroups()
        {
            RoleCarryOuts = new HashSet<RoleCarryOuts>();
            UserRoleGroups = new HashSet<UserRoleGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RoleCarryOuts> RoleCarryOuts { get; set; }
        public ICollection<UserRoleGroups> UserRoleGroups { get; set; }
    }
}
