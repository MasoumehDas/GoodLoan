using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class UserMenuDto : MainEntitiesDto
    {
        public UserMenuDto()
        {
            UserRoleMenuAccess = new HashSet<UserRoleMenuAccessDto>();
        }
        public int UserMenuId { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public bool? IsShow { get; set; }
        public virtual ICollection<UserRoleMenuAccessDto> UserRoleMenuAccess { get; set; }
    }
}
