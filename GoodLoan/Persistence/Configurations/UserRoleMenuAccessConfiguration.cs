using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{
    
    internal sealed class UserRoleMenuAccessConfiguration : IEntityTypeConfiguration<UserRoleMenuAccess>
    {
        public void Configure(EntityTypeBuilder<UserRoleMenuAccess> builder)
        {
            builder.ToTable(nameof(UserRoleMenuAccess));
            builder.HasKey(user => new { user.UserRoleMenuAccessId });
           
            builder.Property(user => user.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(user => user.Active).HasDefaultValue(true);
            builder.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserRoleMenuAccess)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRoleMenuAccess_UserRole");
            builder.HasOne(d => d.UserMenu)
                    .WithMany(p => p.UserRoleMenuAccess)
                    .HasForeignKey(d => d.UserMenuId)
                    .HasConstraintName("FK_UserRoleMenuAccess_UserMenu");

        }
    }
    
    
}
