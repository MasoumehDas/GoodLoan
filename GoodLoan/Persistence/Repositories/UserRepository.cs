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
    public sealed class UserRepository : IUserRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public UserRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public void Delete(User user)
        {
             _dbContext.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            //var ss= await _dbContext.Users.Include(a=>a.UserRole).ToListAsync(cancellationToken);
            var ss = await _dbContext.Users.ToListAsync(cancellationToken);
            return ss.ToList();
        }

        public async Task<User> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(a => a.UserId == UserId, cancellationToken);
        }

        public void Insert(User user)
        {
            _dbContext.Add(user);
        }

        
    }
}
