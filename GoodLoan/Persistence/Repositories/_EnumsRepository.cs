using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Persistence.Repositories
{
    public class _EnumsRepository : I_EnumsRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public _EnumsRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public async Task<_Enums> GetBy_EnumIdAsync(int _EnumId) => 
            await _dbContext._Enums.FirstOrDefaultAsync(a => a.Id == _EnumId);

        public async Task<List<_Enums>> GetBy_EntitiyUsedAsync(string EntitiyUsed) => 
            await _dbContext._Enums.Where(a => a.EntitiyUsed == EntitiyUsed).ToListAsync();
        

        public async Task<IEnumerable<_Enums>> GetBy_EnumsValueAsync(string EntitiyUsed, string _EnumsValue) => 
            await _dbContext._Enums.Where(a => a.EntitiyUsed == EntitiyUsed && a.EnumsValue == _EnumsValue).ToListAsync();

        
    }
}
