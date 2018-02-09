﻿using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Data.Extensions.MsSql;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aurochses.Module.Address.Data.Mappings
{
    /// <summary>
    /// Class CityConfiguration.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.EntityTypeConfiguration{CityEntity, Int32}" />
    public class CityConfiguration : EntityTypeConfiguration<CityEntity, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityConfiguration"/> class.
        /// </summary>
        /// <param name="schemaName">Name of the schema.</param>
        public CityConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        /// <summary>
        /// Maps the specified entity type builder.
        /// </summary>
        /// <param name="entityTypeBuilder">The entity type builder.</param>
        public override void Map(EntityTypeBuilder<CityEntity> entityTypeBuilder)
        {
            // Table
            entityTypeBuilder.ToTable("City", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);

            // Properties
            entityTypeBuilder.Property(x => x.CountyId);
            entityTypeBuilder.Property(x => x.DisplayName).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength()).IsRequired();

            // Relationships
            entityTypeBuilder.HasOne(x => x.County)
                .WithMany()
                .HasForeignKey(x => x.CountyId);
        }
    }
}