using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserSubMenu : MainEntities
    {
        public UserSubMenu()
        {
            UserRoleMenuAccess = new HashSet<UserRoleMenuAccess>();
        }
        public int UserSubMenuId { get; set; }
        public string ControlID { get; set; }
        public string SelectorID { get; set; }
        public string MenuTitle { get; set; }
        public string Lang { get; set; }
        public bool? IsShowMenu { get; set; }
        public virtual ICollection<UserRoleMenuAccess> UserRoleMenuAccess { get; set; }
    }
}
