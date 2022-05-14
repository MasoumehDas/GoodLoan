
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class UserDto : MainEntitiesDto
    {
        public UserDto()
        {
            Loans = new HashSet<LoanDto>();
            //Payments = new HashSet<PaymentDto>();

        }
        public int UserId { get; set; }
        //public int RoleId { get; set; }
        //public string FullName { get; set; }
        //public string Email { get; set; }
        //public string Mobile { get; set; }
        //public byte UserGender { get; set; }
        //public byte UserStatusLife { get; set; }
        //public byte UserActiveType { get; set; }
        //public byte UserStatus { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }

        public UserRoleDto UserRole { get; set; }

        public virtual ICollection<LoanDto> Loans { get; set; }
        //public virtual ICollection<PaymentDto> Payments { get; set; }
        public string RoleName { get { return UserRole.RoleName; } }
        //public string CardNumber { get; set; }
        //public string BankName { get; set; }

        

    }
    

}
