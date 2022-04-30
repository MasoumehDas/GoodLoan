using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Contracts.Models;
namespace Services.Abstractions
{
   public interface IUserService
    {
        Task<IList<UserDto>> GetAllAsync(CancellationToken cancellationToken = default);
        
    }
}
