using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class PaymentDto : MainEntitiesDto
    {
        public PaymentDto()
        {
            Installments = new HashSet<InstallmentDto>();
            Loans = new HashSet<LoanDto>();
        }
        public int PaymentId { get; set; }
        public int? UserId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentDate_Shamsi { get; set; }
        public long Amount { get; set; }
        public byte PaymentStatus { get; set; }
        public string CardNumber { get; set; }
        public string FileUload { get; set; }
        public string RefrenceNumber { get; set; }
        public bool Confirm { get; set; }
        public int? ConfirmUserId { get; set; }
        public string ConfirmUserDescription { get; set; }
        public virtual UserDto User { get; set; }
        public virtual ICollection<InstallmentDto> Installments { get; set; }
        public virtual ICollection<LoanDto> Loans { get; set; }

    }
}
