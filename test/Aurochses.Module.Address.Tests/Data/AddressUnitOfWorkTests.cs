using System;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Aurochses.Module.Address.Tests.Data
{
    public class AddressUnitOfWorkTests
    {
        private readonly AddressUnitOfWork _addressUnitOfWork;

        public AddressUnitOfWorkTests()
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DbContext>();

            _addressUnitOfWork = new AddressUnitOfWork(
                dbContext => new Repository<AddressEntity, Guid>(dbContext),
                dbContext => new Repository<CityEntity, int>(dbContext),
                dbContext => new Repository<CountryEntity, int>(dbContext),
                dbContext => new Repository<CountyEntity, int>(dbContext),
                dbContext => new Repository<StateEntity, int>(dbContext),
                dbContextOptionsBuilder.Options,
                "dbo"
            );
        }

        [Fact]
        public void Inherit_UnitOfWork()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<UnitOfWork>(_addressUnitOfWork);
        }

        [Fact]
        public void Inherit_IAddressUnitOfWork()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<IAddressUnitOfWork>(_addressUnitOfWork);
        }

        [Fact]
        public void AddressRepository_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.IsType<Repository<AddressEntity, Guid>>(_addressUnitOfWork.AddressRepository);
        }
    }
}