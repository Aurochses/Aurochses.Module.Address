using Aurochses.Module.Address.Data;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Address.Tests.Fakes.Data
{
    public class FakeAddressDbContext : AddressDbContext
    {
        public FakeAddressDbContext(DbContextOptions dbContextOptions, string schemaName)
            : base(dbContextOptions, schemaName)
        {

        }

        public void TestOnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder);
        }
    }
}