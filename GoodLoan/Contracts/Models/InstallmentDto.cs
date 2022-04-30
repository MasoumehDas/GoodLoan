using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
   public class InstallmentDto : MainEntitiesDto
    {
        public int InstallmentId { get; set; }
        public int LoanId { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime InstallmentDate { get; set; }

        public string PaymentDate_shansi { get; set; }
        public string InstallmentDate_shansi { get; set; }
        public long InstallmentAmount { get; set; }
        public byte InstallmentStatus { get; set; }
        public virtual LoanDto Loan { get; set; }
        public virtual PaymentDto Payment { get; set; }
    }
}
