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
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public AddressUnitOfWork(
            Func<DbContext, IRepository<AddressEntity, Guid>> addressRepository,
            DbContextOptions dbContextOptions,
            string schemaName)
            : base(new AddressDbContext(dbContextOptions, schemaName))
        {
            RegisterRepository(addressRepository(DbContext));
        }

        /// <summary>
        /// Gets the address repository.
        /// </summary>
        /// <value>The address repository.</value>
        public IRepository<AddressEntity, Guid> AddressRepository => GetRepository<AddressEntity, Guid>();
    }
}