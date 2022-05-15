using Domain.Repositories;
using Microsoft.Extensions.Configuration;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IInstallmentRepository> _lazyInstallmentRepository;
        private readonly Lazy<ILoanRepository> _lazyLoanRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;
        private readonly Lazy<IPaymentRepository> _lazyPaymentRepository;
        
        private readonly Lazy<IUserRepository> _lazyUserRepository;
        private readonly Lazy<IUserRoleMenuAccessRepository> _lazyUserRoleMenuAccessRepository;
        private readonly Lazy<IUserRoleRepository> _lazyUserRoleRepository;
        private readonly Lazy<I_EnumsRepository> _lazy_EnumsRepository;
        private readonly Lazy<ISettingRepository> _lazy_SettingRepository;
        public IConfiguration Configuration { get; }
        public RepositoryManager(RepositoryDbContext dbContext)
        {
            string GetConnectionString = "Server=.;Database=GoodLoan;Trusted_Connection=True;";
            _lazyInstallmentRepository = new Lazy<IInstallmentRepository>(() => new InstallmentRepository(dbContext));
            _lazyLoanRepository = new Lazy<ILoanRepository>(() => new LoanRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));

            _lazyPaymentRepository = new Lazy<IPaymentRepository>(() => new PaymentRepository(dbContext));
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
            _lazyUserRoleMenuAccessRepository = new Lazy<IUserRoleMenuAccessRepository>(() => new UserRoleMenuAccessRepository(dbContext));
            _lazyUserRoleRepository =new Lazy<IUserRoleRepository>(() => new UserRoleRepository(dbContext));
            _lazy_EnumsRepository = new Lazy<I_EnumsRepository>(() => new _EnumsRepository(dbContext));
            _lazy_SettingRepository = new Lazy<ISettingRepository>(() => new SettingRepository(dbContext,new ADOConnection<Domain.Entities.Setting>(GetConnectionString)));
        }



        public IInstallmentRepository InstallmentRepository => _lazyInstallmentRepository.Value;

        public ILoanRepository LoanRepository => _lazyLoanRepository.Value;

        public IPaymentRepository PaymentRepository => _lazyPaymentRepository.Value;

        public IUserRepository UserRepository => _lazyUserRepository.Value;

        public IUserRoleMenuAccessRepository UserRoleMenuAccessRepository => _lazyUserRoleMenuAccessRepository.Value;

        public IUserRoleRepository UserRoleRepository => _lazyUserRoleRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;

        public I_EnumsRepository _EnumsRepository => _lazy_EnumsRepository.Value;
        public ISettingRepository SettingRepository => _lazy_SettingRepository.Value;


    }
}
