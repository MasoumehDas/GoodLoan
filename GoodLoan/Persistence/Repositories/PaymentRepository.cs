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
    internal sealed class PaymentRepository : IPaymentRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public PaymentRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public void Delete(Payment Payment)
        {
            _dbContext.Payments.Remove(Payment);
        }

        public async Task<IEnumerable<Payment>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Payments.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Payment>> GetByDateAsync(DateTime? FromDate, DateTime? ToDate, int? UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Payments.Where(a =>
                                                (a.PaymentDate.AddDays(-1) >= FromDate.Value || FromDate == null) &&
                                                (a.PaymentDate.AddDays(1) <= ToDate.Value || ToDate == null) &&
                                                (a.UserId == UserId || UserId == null)
            ).ToListAsync(cancellationToken);
        }
        public async Task<Payment> GetByPaymentIdAsync(int PaymentId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Payments.Where(a => a.PaymentId == PaymentId).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Payment>> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Payments.Where(a => a.UserId == UserId).ToListAsync(cancellationToken);
        }

        public void Insert(Payment Payments)
        {
            _dbContext.Payments.Add(Payments);
        }

        
    }
}
