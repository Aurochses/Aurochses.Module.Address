using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Data.Extensions.MsSql;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aurochses.Module.Address.Data.Mappings
{
    /// <summary>
    /// Class CountryConfiguration.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.EntityTypeConfiguration{CountryEntity, Int32}" />
    public class CountryConfiguration : EntityTypeConfiguration<CountryEntity, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryConfiguration"/> class.
        /// </summary>
        /// <param name="schemaName">Name of the schema.</param>
        public CountryConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        /// <summary>
        /// Maps the specified entity type builder.
        /// </summary>
        /// <param name="entityTypeBuilder">The entity type builder.</param>
        public override void Map(EntityTypeBuilder<CountryEntity> entityTypeBuilder)
        {
            // Table
            entityTypeBuilder.ToTable("Country", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);

            // Properties
            entityTypeBuilder.Property(x => x.DisplayName).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength()).IsRequired();
            entityTypeBuilder.Property(x => x.TwoDigitsAlphabeticCode).IsRequired().HasMaxLength(2);
            entityTypeBuilder.Property(x => x.ThreeDigitsAlphabeticCode).IsRequired().HasMaxLength(3);
        }
    }
}