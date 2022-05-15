using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models
{
    public class UserSubMenuDto : MainEntitiesDto
    {
        public UserSubMenuDto()
        {
            UserRoleMenuAccess = new HashSet<UserRoleMenuAccessDto>();
        }
        public int UserSubMenuId { get; set; }
        public string ControlID { get; set; }
        public string SelectorID { get; set; }
        public string MenuTitle { get; set; }
        public string Lang { get; set; }
        public bool? IsShowMenu { get; set; }
        public virtual ICollection<UserRoleMenuAccessDto> UserRoleMenuAccess { get; set; }
    }
}
