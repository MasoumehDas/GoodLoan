using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class UserRoleMenuAccess : MainEntities
    {
        public int UserRoleMenuAccessId { get; set; }
        public int RoleId { get; set; }
        public int UserMenuId { get; set; }
       
        public UserMenu UserMenu { get; set; }
        public UserRole UserRole { get; set; }

    }
}
