using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{
   
    internal sealed class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));
            builder.HasKey(Payment => new { Payment.PaymentId });
            builder.Property(Payment => Payment.PaymentId).ValueGeneratedOnAdd();
            builder.Property(Payment => Payment.RefrenceNumber).HasMaxLength(20);
            builder.Property(Payment => Payment.CardNumber).HasMaxLength(20);
            builder.Property(Payment => Payment.PaymentDate).IsRequired();
            builder.Property(Payment => Payment.Amount).IsRequired();
            builder.Property(Payment => Payment.Amount).IsRequired();
            builder.Property(Payment => Payment.PaymentStatus).IsRequired();
            builder.Property(Payment => Payment.PaymentDate_Shamsi).HasMaxLength(11);
            builder.Property(Payment => Payment.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(Payment => Payment.Active).HasDefaultValue(true);


            builder.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Payment_User");
        }
    }
}
