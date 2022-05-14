using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.Models;
using Domain.Entities;
using Domain.Repositories;

using Services.Abstractions;
namespace Services
{
    public sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryManager = repositoryManager;
            
        }
        public async Task<IList<UserDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result =await  _repositoryManager.UserRepository.GetAllAsync(cancellationToken);

            // var resultDto = MapObject.MappingUserDto(result.ToList());
            var resultDto=_mapper.Map<List<UserDto>>(result);

            return resultDto;
        }
    }
}
