using System;
using Aurochses.Data;

namespace Aurochses.Module.Address.Data.Contract
{
    /// <summary>
    /// Interface IAddressUnitOfWork
    /// </summary>
    /// <seealso cref="Aurochses.Data.IUnitOfWork" />
    public interface IAddressUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets the address repository.
        /// </summary>
        /// <value>The address repository.</value>
        IRepository<AddressEntity, Guid> AddressRepository
        {
            get;
        }

        /// <summary>
        /// Gets the city repository.
        /// </summary>
        /// <value>The city repository.</value>
        IRepository<CityEntity, int> CityRepository
        {
            get;
        }

        /// <summary>
        /// Gets the country repository.
        /// </summary>
        /// <value>The country repository.</value>
        IRepository<CountryEntity, int> CountryRepository
        {
            get;
        }

        /// <summary>
        /// Gets the county repository.
        /// </summary>
        /// <value>The county repository.</value>
        IRepository<CountyEntity, int> CountyRepository
        {
            get;
        }

        /// <summary>
        /// Gets the state repository.
        /// </summary>
        /// <value>The state repository.</value>
        IRepository<StateEntity, int> StateRepository
        {
            get;
        }
    }
}