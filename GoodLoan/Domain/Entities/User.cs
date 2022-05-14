using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
   public class User: MainEntities
    {
        public User()
        {
            Loans = new HashSet<Loan>();
            Payments = new HashSet<Payment>();

        }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public byte UserGender { get; set; }
        public byte UserStatusLife { get; set; }
        public byte UserActiveType { get; set; }
        public byte UserStatus { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }
        public string BankName { get; set; }

        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }


    }
    
}
