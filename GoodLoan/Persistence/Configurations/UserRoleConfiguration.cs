using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{
    internal sealed class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(nameof(UserRole));

            builder.HasKey(user => new { user.RoleId });
            builder.Property(user => user.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(user => user.Active).HasDefaultValue(true);


        }
    }
}
