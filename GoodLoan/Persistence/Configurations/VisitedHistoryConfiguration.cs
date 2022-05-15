using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
   public sealed class VisitedHistoryConfiguration
    {
        public void Configure(EntityTypeBuilder<VisitedHistory> builder)
        {
            builder.ToTable(nameof(VisitedHistory));
            builder.HasKey(visited => new { visited.Id });
            builder.Property(visited => visited.Id).ValueGeneratedOnAdd();
            builder.Property(visited => visited.IP).HasMaxLength(15);
            builder.Property(visited => visited.Browser).HasMaxLength(50);
            builder.Property(visited => visited.Date_shansi).HasMaxLength(11);
            builder.Property(visited => visited.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(visited => visited.Active).HasDefaultValue(true);
        }
    }
}
