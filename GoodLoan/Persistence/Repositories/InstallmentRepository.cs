using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Persistence.Repositories
{
    internal sealed class InstallmentRepository : IInstallmentRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public InstallmentRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public void Delete(Installment Installment)
        {
            _dbContext.Installments.Remove(Installment);
        }

        public  void  DeleteAddRangeAsync(List<Installment> Installments)
        {
             _dbContext.Installments.RemoveRange(Installments);
        }

        public async Task<IEnumerable<Installment>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Installments.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Installment>> GetByDateAsync(DateTime? FromDate, DateTime? ToDate, int? UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Installments.Where(a =>
                                                (a.InstallmentDate.AddDays(-1) >= FromDate.Value || FromDate == null) &&
                                                (a.InstallmentDate.AddDays(1) <= ToDate.Value || ToDate == null) &&
                                                (a.Loan.UserId== UserId || UserId == null)
            ).ToListAsync(cancellationToken);
        }

        public async Task<Installment> GetByInstallmentIdAsync(int InstallmentId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Installments.FirstOrDefaultAsync(a=>a.InstallmentId== InstallmentId, cancellationToken);
        }

        public async Task<IEnumerable<Installment>> GetByLoanIdAsync(int LoanId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Installments.Where(a => a.LoanId == LoanId).ToListAsync(cancellationToken);
        }

        public async Task<Installment> GetByPaymentIdAsync(int PaymentId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Installments.FirstOrDefaultAsync(a => a.PaymentId == PaymentId, cancellationToken);
        }

        public async Task<IEnumerable<Installment>> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Installments.Where(a => a.Loan.UserId == UserId).ToListAsync();
        }

        public void Insert(Installment Installments)
        {
            _dbContext.Installments.Add(Installments);
        }

        public void InsertAddRangeAsync(List<Installment> Installments)
        {
            _dbContext.Installments.AddRangeAsync(Installments);
        }

        

       
    }
}
