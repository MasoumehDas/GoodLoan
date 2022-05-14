using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
   public interface I_EnumsRepository
    {
        Task<_Enums> GetBy_EnumIdAsync(int _EnumId);
        Task<List<_Enums>> GetBy_EntitiyUsedAsync(string EntitiyUsed);
        Task<IEnumerable<_Enums>> GetBy_EnumsValueAsync(string EntitiyUsed, string _EnumsValue);
    }
}
