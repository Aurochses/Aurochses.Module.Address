using System;
using Aurochses.Data;
using Aurochses.Module.Address.Data;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Address.Tests.Fakes.Data
{
    public class FakeAddressUnitOfWork : AddressUnitOfWork
    {
        public FakeAddressUnitOfWork(
            Func<DbContext, IRepository<AddressEntity, Guid>> addressRepository,
            Func<DbContext, IRepository<CityEntity, int>> cityRepository,
            Func<DbContext, IRepository<CountryEntity, int>> countryRepository,
            Func<DbContext, IRepository<CountyEntity, int>> countyRepository,
            Func<DbContext, IRepository<StateEntity, int>> stateRepository,
            DbContextOptions dbContextOptions,
            string schemaName)
            : base(addressRepository, cityRepository, countryRepository, countyRepository, stateRepository, dbContextOptions, schemaName)
        {

        }
    }
}