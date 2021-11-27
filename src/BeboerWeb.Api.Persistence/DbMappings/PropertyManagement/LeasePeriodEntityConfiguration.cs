﻿using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.PropertyManagement
{
    internal class LeasePeriodEntityConfiguration : IEntityTypeConfiguration<LeasePeriod>
    {
        public void Configure(EntityTypeBuilder<LeasePeriod> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.HasMany(p => p.Tenants)
                .WithMany(p => p.LeasePeriods);

            builder.Property(p => p.RowVersion)
                .IsRowVersion();

        }
    }
}
