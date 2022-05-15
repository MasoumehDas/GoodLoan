using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    
    internal sealed class SettingConfiguration : IEntityTypeConfiguration<Setting> { 
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.ToTable(nameof(Setting));
            builder.HasKey(setting => new { setting.SettingId });
            builder.Property(setting => setting.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(setting => setting.Active).HasDefaultValue(true);
            builder.Property(setting => setting.SettingName).HasMaxLength(50);
            builder.Property(setting => setting.SettinCaption).HasMaxLength(50);
            builder.Property(setting => setting.SettingValue).HasMaxLength(50);
            builder.Property(setting => setting.Category).HasMaxLength(50);

        }
    }
}
