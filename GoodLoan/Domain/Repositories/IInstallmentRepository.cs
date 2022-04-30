using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
   
    public interface IInstallmentRepository
    {
        void InsertAddRangeAsync(List<Entities.Installment> Installments);
        void Insert(Entities.Installment Installments);
        void Delete(Entities.Installment Installment);
        void DeleteAddRangeAsync(List<Entities.Installment> Installments);

        Task<Installment> GetByInstallmentIdAsync(int InstallmentId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Installment>> GetByLoanIdAsync(int LoanId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Installment>> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default);
        Task<Installment> GetByPaymentIdAsync(int PaymentId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Installment>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<Installment>> GetByDateAsync(DateTime? FromDate, DateTime? ToDate, int? UserId, CancellationToken cancellationToken = default);

    }
    
}
