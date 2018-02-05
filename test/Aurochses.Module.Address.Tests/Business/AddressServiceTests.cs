using Aurochses.Module.Address.Business;
using Aurochses.Module.Address.Business.Contract;
using Aurochses.Module.Address.Data.Contract;
using Moq;
using Xunit;

namespace Aurochses.Module.Address.Tests.Business
{
    public class AddressServiceTests
    {
        [Fact]
        public void Inherit_IAddressService()
        {
            // Arrange & Act
            var mockUnitOfWork = new Mock<IAddressUnitOfWork>();

            // Assert
            Assert.IsAssignableFrom<IAddressService>(new AddressService(mockUnitOfWork.Object));
        }
    }
}