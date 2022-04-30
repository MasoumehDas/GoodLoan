using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserRole : MainEntities
    {
        public UserRole()
        {
            Users = new HashSet<User>();
            UserRoleMenuAccess = new HashSet<UserRoleMenuAccess>();
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UserRoleMenuAccess> UserRoleMenuAccess { get; set; }
    }
}
