using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public  interface IUserRepository
    {
        void Insert(Entities.User user);
        
        void Delete (Entities.User user);
        Task<User> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default);
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);

    }
}
