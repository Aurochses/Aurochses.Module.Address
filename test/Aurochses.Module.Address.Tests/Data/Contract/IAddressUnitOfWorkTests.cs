using System;
using Aurochses.Data;
using Aurochses.Module.Address.Data.Contract;
using Moq;
using Xunit;

namespace Aurochses.Module.Address.Tests.Data.Contract
{
    // ReSharper disable once InconsistentNaming
    public class IAddressUnitOfWorkTests
    {
        [Fact]
        public void Inherit_IUnitOfWork()
        {
            // Arrange
            var mockAddressUnitOfWork = new Mock<IAddressUnitOfWork>(MockBehavior.Strict);

            // Act & Assert
            Assert.IsAssignableFrom<IUnitOfWork>(mockAddressUnitOfWork.Object);
        }

        [Fact]
        public void AddressRepository_Get_Success()
        {
            // Arrange
            var mockAddressRepository = new Mock<IRepository<AddressEntity, Guid>>(MockBehavior.Strict);

            var mockAddressUnitOfWork = new Mock<IAddressUnitOfWork>(MockBehavior.Strict);
            mockAddressUnitOfWork.SetupGet(m => m.AddressRepository).Returns(mockAddressRepository.Object);

            // Act & Assert
            Assert.Equal(mockAddressRepository.Object, mockAddressUnitOfWork.Object.AddressRepository);
        }
    }
}