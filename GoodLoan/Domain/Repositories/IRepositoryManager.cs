using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IInstallmentRepository InstallmentRepository { get; }
        ILoanRepository LoanRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IUserRepository UserRepository { get; }
        IUserRoleMenuAccessRepository UserRoleMenuAccessRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        IUnitOfWork UnitOfWork { get; }
        I_EnumsRepository _EnumsRepository { get; }
    }
}
