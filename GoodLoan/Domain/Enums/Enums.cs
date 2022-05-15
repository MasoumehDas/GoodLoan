using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Enums
{

    //Types of financial transactions
   public enum PaymentStatus
    {
        
        Receipt=1,//دریافت
        Pay=2//پرداخت
        
    }

    public enum LoanStatus
    {
        Cleared = 1,//تسویه شده
        Normal = 2,//عادی
        Delayed = 3,//عقب افتاده
        Donated=4//اهدا شده
    }
    public enum InstallmentStatus
    {
        Cleared = LoanStatus.Cleared,//تسویه شده
        Normal =  LoanStatus.Normal,//عادی
        Delayed = LoanStatus.Delayed,//عقب افتاده
        Donated = LoanStatus.Donated//اهدا شده
    }
    public enum UserActiveType
    {
        Active = 1,//فعال
        Blocked = 2,//مسدود
        
    }
    public enum UserStatusLife
    {
        living=1,//زنده
        Dead=2 //مرده
    }
    public enum UserStatus
    {
        Donator = 1,//اهدا کننده
        Borrower = 2,//وام گیرنده
        LoanApplicant = 3,//متقاضی وام
        Sponsor = 4//ضامن
    }
    public enum UserGender
    {
        Famale= 1,//زن
        Man = 2 //مرد
    }
}
