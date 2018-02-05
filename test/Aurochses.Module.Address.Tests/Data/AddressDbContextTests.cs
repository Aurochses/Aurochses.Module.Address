using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data;
using Aurochses.Module.Address.Data.Contract;
using Aurochses.Module.Address.Tests.Fakes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Xunit;

namespace Aurochses.Module.Address.Tests.Data
{
    public class AddressDbContextTests
    {
        [Fact]
        public void Inherit_DbContextBase()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            // Act & Assert
            Assert.IsAssignableFrom<DbContextBase>(new AddressDbContext(dbContextOptionsBuilder.Options, "dbo"));
        }

        [Fact]
        public void OnModelCreating_AddressDbContext_Success()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            var dbContext = new FakeAddressDbContext(dbContextOptionsBuilder.Options, "dbo");

            var modelBuilder = new ModelBuilder(new ConventionSet());

            // Act
            dbContext.TestOnModelCreating(modelBuilder);

            // Assert
            Assert.NotNull(modelBuilder.Model.FindEntityType(typeof(AddressEntity)));
        }
    }
}