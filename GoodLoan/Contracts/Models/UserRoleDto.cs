using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class UserRoleDto : MainEntitiesDto
    {
        public UserRoleDto()
        {
            Users = new HashSet<UserDto>();
            UserRoleMenuAccess = new HashSet<UserRoleMenuAccessDto>();
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<UserDto> Users { get; set; }
        public virtual ICollection<UserRoleMenuAccessDto> UserRoleMenuAccess { get; set; }
    }
}
