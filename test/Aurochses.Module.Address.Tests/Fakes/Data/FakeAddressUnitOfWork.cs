using System;
using Aurochses.Data;
using Aurochses.Module.Address.Data;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Address.Tests.Fakes.Data
{
    public class FakeAddressUnitOfWork : AddressUnitOfWork
    {
        public FakeAddressUnitOfWork(Func<DbContext, IRepository<AddressEntity, Guid>> addressRepository, DbContextOptions dbContextOptions, string schemaName)
            : base(addressRepository, dbContextOptions, schemaName)
        {

        }
    }
}