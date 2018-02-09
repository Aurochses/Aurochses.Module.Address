using Aurochses.Module.Autofac.EntityFrameworkCore;
using Aurochses.Module.Address.Tests.Business;
using Aurochses.Module.Address.Tests.Data;
using Aurochses.Module.Address.Tests.Fakes;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Aurochses.Module.Address.Tests
{
    public class AddressModuleTests
    {
        [Fact]
        public void Inherit_ModuleBase()
        {
            // Arrange
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            // Act
            var addressModule = new AddressModule(dbContextOptionsBuilder.Options, "dbo");

            // Assert
            Assert.IsAssignableFrom<ModuleBase>(addressModule);
        }

        [Fact]
        public void Load_AddressModule_Success()
        {
            // Arrange
            var containerBuilder = new ContainerBuilder();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();
            var addressModule = new FakeAddressModule(dbContextOptionsBuilder.Options);

            // Act
            addressModule.TestLoad(containerBuilder);

            var container = containerBuilder.Build();

            // Assert
            DataModuleTests.CheckIfAllTypesRegistered(container);
            BusinessModuleTests.CheckIfAllTypesRegistered(container);
        }
    }
}