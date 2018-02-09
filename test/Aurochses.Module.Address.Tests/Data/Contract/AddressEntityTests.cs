using System;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data.Contract;
using Xunit;

namespace Aurochses.Module.Address.Tests.Data.Contract
{
    public class AddressEntityTests
    {
        [Fact]
        public void Inherit_EntityNoneDatabaseGeneratedIdentifier()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<Entity<Guid>>(new AddressEntity());
        }
    }
}