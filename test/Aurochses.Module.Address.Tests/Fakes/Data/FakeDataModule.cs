using Aurochses.Module.Address.Data;
using Autofac;

namespace Aurochses.Module.Address.Tests.Fakes.Data
{
    public class FakeDataModule : DataModule
    {
        public void TestLoad(ContainerBuilder builder)
        {
            Load(builder);
        }
    }
}