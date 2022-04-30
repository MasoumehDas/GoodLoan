using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRoleRepository
    {
       
        Task<UserRole> GetByUserRoleIdAsync(int LoanId, CancellationToken cancellationToken = default);
        Task<IEnumerable<UserRole>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
