﻿// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Models - DriverConfiguration.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Models.Entities.Configuration;

public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder
            .Property(e => e.TimeStamp)
            .HasConversion<byte[]>();

        builder.ComplexProperty(cp => cp.PersonInformation,
            pd =>
            {
                pd.Property<string>(nameof(Person.FirstName))
                    .HasColumnName(nameof(Person.FirstName))
                    .HasColumnType("nvarchar(50)");
                pd.Property<string>(nameof(Person.LastName))
                    .HasColumnName(nameof(Person.LastName))
                    .HasColumnType("nvarchar(50)");
                pd.Property(p => p.FullName)
                    .HasColumnName(nameof(Person.FullName))
                    .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");
                pd.IsRequired(true);
            });

        builder.ToTable( b => b.IsTemporal(t =>
        {
            t.HasPeriodEnd("ValidTo");
            t.HasPeriodStart("ValidFrom");
            t.UseHistoryTable("DriversAudit");
        }));

    }
}