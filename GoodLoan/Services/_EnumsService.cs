using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Contracts.Models;
using Domain.Entities;
using Domain.Repositories;

using Services.Abstractions;
namespace Services
{
    public sealed class _EnumsService : I_EnumsService
    {
        private readonly IRepositoryManager _repositoryManager;
        public _EnumsService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
        
        public async Task<IList<_EnumsDto>> GetBy_EnumsTypeAsync(string _EnumsType)
        {
            var result = await _repositoryManager._EnumsRepository.GetBy_EntitiyUsedAsync(_EnumsType);
           
            var list = MapObject.Mapping_EnumsDto(result.ToList());
            return list;
        }
    }
}
