using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations
{
    internal sealed class UserSubMenuConfiguration : IEntityTypeConfiguration<UserSubMenu>
    {
        public void Configure(EntityTypeBuilder<UserSubMenu> builder)
        {
            builder.ToTable(nameof(UserSubMenu));

            builder.HasKey(user => new { user.UserSubMenuId });
            builder.Property(user => user.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(user => user.Active).HasDefaultValue(true);
            builder.Property(user => user.IsShowMenu).HasDefaultValue(true);
            builder.Property(user => user.ControlID).HasMaxLength(50);
            builder.Property(user => user.SelectorID).HasMaxLength(50);
            builder.Property(user => user.MenuTitle).HasMaxLength(50);


        }
    }
}
