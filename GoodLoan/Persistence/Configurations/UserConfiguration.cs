using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
   
    internal sealed class UserBroConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(user => new { user.UserId });
            builder.Property(user => user.UserId).ValueGeneratedOnAdd();
            builder.Property(user => user.FullName).HasMaxLength(50);
            builder.Property(user => user.UserName).HasMaxLength(20);
            builder.Property(user => user.Password).HasMaxLength(20);
            builder.Property(user => user.Email).HasMaxLength(200);
            builder.Property(user => user.Mobile).HasMaxLength(11);
           
            builder.Property(user => user.FullName).IsRequired();
            builder.Property(user => user.Mobile).IsRequired();
            builder.Property(user => user.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(user => user.Active).HasDefaultValue(true);
            builder.Property(user => user.CardNumber).HasMaxLength(20);
            builder.Property(user => user.BankName).HasMaxLength(50);
           
            builder.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_User");
            
        }
    }
    

}
