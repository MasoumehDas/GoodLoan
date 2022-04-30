using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    
    public interface IPaymentRepository
    {
       
        void Insert(Entities.Payment Payments);
        void Delete(Entities.Payment Payment);
        
        Task<Payment> GetByPaymentIdAsync(int PaymentId, CancellationToken cancellationToken = default);
        
        Task<IEnumerable<Payment>> GetByUserIdAsync(int UserId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Payment>> GetByDateAsync(DateTime? FromDate, DateTime? ToDate, int? UserId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Payment>> GetAllAsync(CancellationToken cancellationToken = default);

    }
   

}
