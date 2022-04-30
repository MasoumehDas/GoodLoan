using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ILoanRepository
    {
        void Insert(Entities.Loan Loans);
        void Delete(Entities.Loan Loan);

        Task<Loan> GetByLoanIdAsync(int LoanId, CancellationToken cancellationToken = default);
        Task<Loan> GetByPaymentIdAsync(int PaymentId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Loan>> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Loan>> GetBySponsorIdAsync(int SponsorId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Loan>> GetByDateAsync(DateTime? FromDate, DateTime? ToDate, int? UserId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Loan>> GetAllAsync(CancellationToken cancellationToken = default);
    }
    

}
