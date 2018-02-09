using System;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data.Contract;
using Aurochses.Module.Address.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Xunit;

namespace Aurochses.Module.Address.Tests.Data.Mappings
{
    public class AddressConfigurationTests
    {
        [Fact]
        public void Inherit_EntityTypeConfiguration()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<EntityTypeConfiguration<AddressEntity, Guid>>(new AddressConfiguration("dbo"));
        }

        [Fact]
        public void Map_Entity_Success()
        {
            // Arrange
            const string schemaName = "dbo";
            const string tableName = "Address";

            var addressConfiguration = new AddressConfiguration(schemaName);

            var modelBuilder = new ModelBuilder(new ConventionSet());
            var entityTypeBuilder = modelBuilder.Entity<AddressEntity>();

            // Act
            addressConfiguration.Map(entityTypeBuilder);

            // Assert
            CheckTable(entityTypeBuilder, schemaName, tableName);
            CheckId(entityTypeBuilder);
        }

        private void CheckTable(EntityTypeBuilder<AddressEntity> entityTypeBuilder, string schemaName, string tableName)
        {
            if (schemaName == null) throw new ArgumentNullException(nameof(schemaName));
            if (tableName == null) throw new ArgumentNullException(nameof(tableName));

            var relational = entityTypeBuilder.Metadata.Relational();

            Assert.Equal(schemaName, relational.Schema);
            Assert.Equal(tableName, relational.TableName);
        }

        private void CheckId(EntityTypeBuilder<AddressEntity> entityTypeBuilder)
        {
            var property = entityTypeBuilder.Property(x => x.Id);

            Assert.True(property.Metadata.IsPrimaryKey());
            Assert.False(property.Metadata.IsStoreGeneratedAlways);
        }
    }
}