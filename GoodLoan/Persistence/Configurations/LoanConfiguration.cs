using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{

    internal sealed class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable(nameof(Loan));
            builder.HasKey(Loan => new { Loan.LoanId });
            builder.Property(Loan => Loan.LoanId).ValueGeneratedOnAdd();

            builder.Property(Payment => Payment.PaymentDate_Shamsi).HasMaxLength(11);
            builder.Property(Loan => Loan.LoanAmount).IsRequired();
            builder.Property(Loan => Loan.LoanStatus).IsRequired();
            builder.Property(Loan => Loan.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(Loan => Loan.Active).HasDefaultValue(true);



            builder.HasOne(d => d.User)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Loan_User");

            builder.HasOne(d => d.Payment)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Loan_Payment");

        }
    }
}
