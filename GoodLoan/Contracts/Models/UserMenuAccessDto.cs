using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
   public class UserRoleMenuAccessDto : MainEntitiesDto
    {
        public int UserRoleMenuAccessId { get; set; }
        public int RoleId { get; set; }
        public int UserMenuId { get; set; }
       
        public UserMenuDto UserMenu { get; set; }
        public UserRoleDto UserRole { get; set; }

    }
}
