using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class Loan: MainEntities
    {
        public Loan()
        {
            Installments = new HashSet<Installment>();
        }
        public int LoanId { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDate_Shamsi { get; set; }
        public int UserId { get; set; }
        public int? UserSponsorId { get; set; }
        public long LoanAmount { get; set; }
        public long? RemainAmount { get; set; }
        public long? InstallmentAmount { get; set; }
        public int? InstallmentCount { get; set; }
        public byte LoanStatus { get; set; }
        
        public virtual User User { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<Installment> Installments { get; set; }
    }
}
