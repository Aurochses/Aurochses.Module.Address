using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Data.Extensions.MsSql;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aurochses.Module.Address.Data.Mappings
{
    /// <summary>
    /// Class CountyConfiguration.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.EntityTypeConfiguration{CountyEntity, Int32}" />
    public class CountyConfiguration : EntityTypeConfiguration<CountyEntity, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountyConfiguration"/> class.
        /// </summary>
        /// <param name="schemaName">Name of the schema.</param>
        public CountyConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        /// <summary>
        /// Maps the specified entity type builder.
        /// </summary>
        /// <param name="entityTypeBuilder">The entity type builder.</param>
        public override void Map(EntityTypeBuilder<CountyEntity> entityTypeBuilder)
        {
            // Table
            entityTypeBuilder.ToTable("County", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);

            // Properties
            entityTypeBuilder.Property(x => x.StateId);
            entityTypeBuilder.Property(x => x.DisplayName).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength()).IsRequired();

            // Relationships
            entityTypeBuilder.HasOne(x => x.State)
                .WithMany()
                .HasForeignKey(x => x.StateId);
        }
    }
}