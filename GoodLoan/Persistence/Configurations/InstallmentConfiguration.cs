using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{
  
    internal sealed class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
    {
        public void Configure(EntityTypeBuilder<Installment> builder)
        {
            builder.ToTable(nameof(Installment));
            builder.HasKey(Installment =>  new { Installment.InstallmentId });
            builder.Property(Installment => Installment.InstallmentId).ValueGeneratedOnAdd();  
            builder.Property(Installment => Installment.InstallmentDate).IsRequired();
            builder.Property(Installment => Installment.InstallmentAmount).IsRequired();
            builder.Property(Installment => Installment.InstallmentStatus).IsRequired();
            builder.Property(Installment => Installment.InstallmentDate_shansi).HasMaxLength(11);
            builder.Property(Installment => Installment.PaymentDate_shansi).HasMaxLength(11);
            builder.Property(Installment => Installment.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(Installment => Installment.Active).HasDefaultValue(true);


            builder.HasOne(d => d.Loan)
                    .WithMany(p => p.Installments)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Installment_Loan")
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Payment)
                .WithMany(p => p.Installments)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("FK_Installment_Payment")
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
