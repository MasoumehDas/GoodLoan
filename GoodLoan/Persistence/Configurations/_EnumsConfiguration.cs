using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configurations
{
    public class _EnumsConfiguration : IEntityTypeConfiguration<Domain.Entities._Enums>
    {
        public void Configure(EntityTypeBuilder<_Enums> builder)
        {

            builder.ToTable("_Enums");

            builder.Property(e => e.EntitiyUsed).HasMaxLength(50);

            builder.Property(e => e.EnumsType).HasMaxLength(50);

            builder.Property(e => e.EnumsValue).HasMaxLength(50);
            
        }
    }
}
