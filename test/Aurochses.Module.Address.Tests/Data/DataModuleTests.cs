using System;
using Aurochses.Data;
using Aurochses.Module.Address.Data;
using Aurochses.Module.Address.Data.Contract;
using Aurochses.Module.Address.Tests.Fakes.Data;
using Aurochses.Module.Data.Autofac;
using Autofac;
using Xunit;

namespace Aurochses.Module.Address.Tests.Data
{
    public class DataModuleTests
    {
        [Fact]
        public void Inherit_DataModuleBase()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<DataModuleBase>(new DataModule());
        }

        [Fact]
        public void Load_Success()
        {
            // Arrange
            var containerBuilder = new ContainerBuilder();

            var dataModule = new FakeDataModule();

            // Act
            dataModule.TestLoad(containerBuilder);

            var container = containerBuilder.Build();

            // Assert
            CheckIfAllTypesRegistered(container);
        }

        internal static void CheckIfAllTypesRegistered(IContainer container)
        {
            Assert.True(container.IsRegistered<IRepository<AddressEntity, Guid>>());
        }
    }
}