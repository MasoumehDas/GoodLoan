using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Persistence.Repositories
{
    internal sealed class UserRoleMenuAccessRepository : IUserRoleMenuAccessRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public UserRoleMenuAccessRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<UserRoleMenuAccess> GetByUserRoleIdAndMenuIdAsync(int? RoleId, int? UserMenuId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.UserRoleMenuAccess.Where(a => a.RoleId == RoleId && a.UserMenuId == UserMenuId).FirstOrDefaultAsync(cancellationToken);
        }

        
        public async Task<IEnumerable<UserRoleMenuAccess>> GetByUserRoleIdAsync(int? RoleId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.UserRoleMenuAccess.Where(a => a.RoleId == RoleId ).ToListAsync(cancellationToken);
        }
    }
}
