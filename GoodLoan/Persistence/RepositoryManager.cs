using Domain.Repositories;
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

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyInstallmentRepository = new Lazy<IInstallmentRepository>(() => new InstallmentRepository(dbContext));
            _lazyLoanRepository = new Lazy<ILoanRepository>(() => new LoanRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));

            _lazyPaymentRepository = new Lazy<IPaymentRepository>(() => new PaymentRepository(dbContext));
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
            _lazyUserRoleMenuAccessRepository = new Lazy<IUserRoleMenuAccessRepository>(() => new UserRoleMenuAccessRepository(dbContext));
            _lazyUserRoleRepository =new Lazy<IUserRoleRepository>(() => new UserRoleRepository(dbContext));
        }



        public IInstallmentRepository InstallmentRepository => _lazyInstallmentRepository.Value;

        public ILoanRepository LoanRepository => _lazyLoanRepository.Value;

        public IPaymentRepository PaymentRepository => _lazyPaymentRepository.Value;

        public IUserRepository UserRepository => _lazyUserRepository.Value;

        public IUserRoleMenuAccessRepository UserRoleMenuAccessRepository => _lazyUserRoleMenuAccessRepository.Value;

        public IUserRoleRepository UserRoleRepository => _lazyUserRoleRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}
