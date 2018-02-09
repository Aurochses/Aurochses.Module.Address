using System;
using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data.Contract;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Address.Data
{
    /// <summary>
    /// Class AddressUnitOfWork.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.UnitOfWork" />
    /// <seealso cref="Aurochses.Module.Address.Data.Contract.IAddressUnitOfWork" />
    public class AddressUnitOfWork : UnitOfWork, IAddressUnitOfWork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressUnitOfWork"/> class.
        /// </summary>
        /// <param name="addressRepository">The address repository.</param>
        /// <param name="cityRepository">The city repository.</param>
        /// <param name="countryRepository">The country repository.</param>
        /// <param name="countyRepository">The county repository.</param>
        /// <param name="stateRepository">The state repository.</param>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public AddressUnitOfWork(
            Func<DbContext, IRepository<AddressEntity, Guid>> addressRepository,
            Func<DbContext, IRepository<CityEntity, int>> cityRepository,
            Func<DbContext, IRepository<CountryEntity, int>> countryRepository,
            Func<DbContext, IRepository<CountyEntity, int>> countyRepository,
            Func<DbContext, IRepository<StateEntity, int>> stateRepository,
            DbContextOptions dbContextOptions,
            string schemaName)
            : base(new AddressDbContext(dbContextOptions, schemaName))
        {
            RegisterRepository(addressRepository(DbContext));
            RegisterRepository(cityRepository(DbContext));
            RegisterRepository(countryRepository(DbContext));
            RegisterRepository(countyRepository(DbContext));
            RegisterRepository(stateRepository(DbContext));
        }

        /// <summary>
        /// Gets the address repository.
        /// </summary>
        /// <value>The address repository.</value>
        public IRepository<AddressEntity, Guid> AddressRepository => GetRepository<AddressEntity, Guid>();

        /// <summary>
        /// Gets the city repository.
        /// </summary>
        /// <value>The city repository.</value>
        public IRepository<CityEntity, int> CityRepository => GetRepository<CityEntity, int>();

        /// <summary>
        /// Gets the country repository.
        /// </summary>
        /// <value>The country repository.</value>
        public IRepository<CountryEntity, int> CountryRepository => GetRepository<CountryEntity, int>();

        /// <summary>
        /// Gets the county repository.
        /// </summary>
        /// <value>The county repository.</value>
        public IRepository<CountyEntity, int> CountyRepository => GetRepository<CountyEntity, int>();

        /// <summary>
        /// Gets the state repository.
        /// </summary>
        /// <value>The state repository.</value>
        public IRepository<StateEntity, int> StateRepository => GetRepository<StateEntity, int>();
    }
}