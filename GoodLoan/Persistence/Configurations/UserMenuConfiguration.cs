using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{
    internal sealed class UserMenuConfiguration : IEntityTypeConfiguration<UserMenu>
    {
        public void Configure(EntityTypeBuilder<UserMenu> builder)
        {
            builder.ToTable(nameof(UserMenu));

            builder.HasKey(user => new { user.UserMenuId });
            builder.Property(user => user.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(user => user.Active).HasDefaultValue(true);
            builder.Property(user => user.IsShow).HasDefaultValue(true);
            builder.Property(user => user.ControlID).HasMaxLength(50);
            builder.Property(user => user.Title).HasMaxLength(50);

        }
    }
    
}
