using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Contracts.Models;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstractions;
namespace Services
{
    public sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        public UserService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
        public async Task<IList<UserDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result =await  _repositoryManager.UserRepository.GetAllAsync(cancellationToken);

            IList<UserDto> userDtos=new List<UserDto>()  ;
            result.ToList().ForEach(a=> {
                UserDto userDto = new UserDto();
                userDto= Mapper<User, UserDto>.MapProp(a, userDto);
                userDtos.Add(userDto);
                });
            //var resultDto =result.Adapt<IEnumerable<UserDto>>();

            return userDtos;
        }
    }
}
