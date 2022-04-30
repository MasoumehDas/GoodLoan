using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    internal sealed class UserRoleRepository : IUserRoleRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public UserRoleRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<UserRole>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.UserRole.ToListAsync(cancellationToken);
        }

        public async Task<UserRole> GetByUserRoleIdAsync(int LoanId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.UserRole.FirstOrDefaultAsync(a => a.RoleId == LoanId,cancellationToken);
         }
    }
}
