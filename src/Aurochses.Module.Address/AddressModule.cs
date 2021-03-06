﻿using Aurochses.Module.Address.Business;
using Aurochses.Module.Address.Data;
using Aurochses.Module.Autofac.EntityFrameworkCore;
using Autofac;
using Microsoft.EntityFrameworkCore;

namespace Aurochses.Module.Address
{
    /// <summary>
    /// Class AddressModule.
    /// </summary>
    /// <seealso cref="Aurochses.Module.Autofac.EntityFrameworkCore.ModuleBase" />
    public class AddressModule : ModuleBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressModule"/> class.
        /// </summary>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public AddressModule(DbContextOptions dbContextOptions, string schemaName = "aurochses_address")
            : base(dbContextOptions, schemaName)
        {

        }

        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>Note that the ContainerBuilder parameter is unique to this module.</remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataModule());
            builder.RegisterModule(new BusinessModule(DbContextOptions, SchemaName));
        }
    }
}