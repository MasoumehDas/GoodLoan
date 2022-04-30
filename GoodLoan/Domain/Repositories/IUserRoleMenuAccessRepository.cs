using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
 public  interface IUserRoleMenuAccessRepository
    {
        Task<UserRoleMenuAccess> GetByUserRoleIdAndMenuIdAsync(int? RoleId, int? UserMenuId, CancellationToken cancellationToken = default);
        Task<IEnumerable<UserRoleMenuAccess>> GetByUserRoleIdAsync(int? RoleId, CancellationToken cancellationToken = default);
    }
}
