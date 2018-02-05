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
    }
}