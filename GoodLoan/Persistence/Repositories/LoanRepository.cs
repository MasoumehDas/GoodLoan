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
    internal sealed class LoanRepository : ILoanRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public LoanRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public void Delete(Loan Loan)
        {
            _dbContext.Loans.Remove(Loan);
        }
        public void Insert(Loan Loans)
        {
            _dbContext.Loans.Add(Loans);
        }
        public async Task<IEnumerable<Loan>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loans.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Loan>> GetByDateAsync(DateTime? FromDate, DateTime? ToDate, int? UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loans.Where(a =>
                                                (a.PaymentDate.Value.AddDays(-1) >= FromDate.Value || FromDate == null) &&
                                                (a.PaymentDate.Value.AddDays(1) <= ToDate.Value || ToDate == null) &&
                                                (a.UserId == UserId || UserId == null)
            ).ToListAsync(cancellationToken);
        }

        public async Task<Loan> GetByLoanIdAsync(int LoanId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loans.FirstOrDefaultAsync(a=>a.LoanId== LoanId, cancellationToken);
        }

        public async Task<Loan> GetByPaymentIdAsync(int PaymentId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loans.FirstOrDefaultAsync(a => a.PaymentId == PaymentId, cancellationToken);
        }

        public async Task<IEnumerable<Loan>> GetBySponsorIdAsync(int SponsorId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loans.Where(a=>a.UserSponsorId== SponsorId).ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Loan>> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loans.Where(a => a.UserId == UserId).ToListAsync(cancellationToken);
        }

        

        
    }
}
