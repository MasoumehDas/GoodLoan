using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserMenu : MainEntities
    {
        public UserMenu()
        {
            UserRoleMenuAccess = new HashSet<UserRoleMenuAccess>();
        }
        public int UserMenuId { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public bool? IsShow { get; set; }
        public virtual ICollection<UserRoleMenuAccess> UserRoleMenuAccess { get; set; }
    }
}
