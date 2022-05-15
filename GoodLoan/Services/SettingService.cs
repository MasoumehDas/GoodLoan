using AutoMapper;
using Contracts.Models;
using Domain.Repositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SettingService : ISettingService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public SettingService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryManager = repositoryManager;

        }
        public async Task<List<SettingDto>> GetBySettingProcAsync(string Lang, string UserName, string Category)
        {
            var result = await _repositoryManager.SettingRepository.GetBySettingProcAsync(Lang,UserName,Category);

            var resultDto = _mapper.Map<List<SettingDto>>(result.ToList());

            return resultDto;
        }
    }
}
