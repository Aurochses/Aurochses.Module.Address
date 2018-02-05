using Autofac;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Address.Tests.Fakes
{
    public class FakeAddressModule : AddressModule
    {
        public FakeAddressModule(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public void TestLoad(ContainerBuilder builder)
        {
            Load(builder);
        }
    }
}