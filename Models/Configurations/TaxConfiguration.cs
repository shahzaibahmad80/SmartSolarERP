﻿using SmartSolarERP.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmartSolarERP.Models.Configurations
{
    public class TaxConfiguration : _BaseConfiguration<Tax>
    {
        public override void Configure(EntityTypeBuilder<Tax> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(255);
        }
    }
}
