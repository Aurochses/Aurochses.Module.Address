using System;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aurochses.Module.Address.Data.Mappings
{
    /// <summary>
    /// Class AddressConfiguration.
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Aurochses.Data.EntityFrameworkCore.EntityTypeConfiguration{Aurochses.Module.Address.Data.Contract.AddressEntity, System.Guid}
    ///     </cref>
    /// </seealso>
    public class AddressConfiguration : EntityTypeConfiguration<AddressEntity, Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressConfiguration"/> class.
        /// </summary>
        /// <param name="schemaName">Name of the schema.</param>
        public AddressConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        /// <summary>
        /// Maps the specified entity type builder.
        /// </summary>
        /// <param name="entityTypeBuilder">The entity type builder.</param>
        public override void Map(EntityTypeBuilder<AddressEntity> entityTypeBuilder)
        {
            // Table
            entityTypeBuilder.ToTable("Address", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);
        }
    }
}