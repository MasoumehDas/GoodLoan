using System;
using AutoMapper;
using Domain.Repositories;
using Services.Abstractions;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _lazyUserService;
        private readonly Lazy<I_EnumsService> _lazy_EnumsService;
        private readonly Lazy<ISettingService> _lazyISettingService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
            {
          
            _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper));
            _lazy_EnumsService = new Lazy<I_EnumsService>(() => new _EnumsService(repositoryManager));
            _lazyISettingService = new Lazy<ISettingService>(() => new SettingService(repositoryManager, mapper));

        }
        public IUserService UserService => _lazyUserService.Value;
        public I_EnumsService _EnumsService => _lazy_EnumsService.Value;

        public ISettingService SettingService => _lazyISettingService.Value;


    }
}
