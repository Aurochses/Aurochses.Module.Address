﻿using System;
using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Module.Address.Data.Contract;
using Aurochses.Module.Data.Autofac;
using Autofac;

namespace Aurochses.Module.Address.Data
{
    /// <summary>
    /// Class DataModule.
    /// </summary>
    /// <seealso cref="Aurochses.Module.Data.Autofac.DataModuleBase" />
    public class DataModule : DataModuleBase
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be registered.</param>
        /// <remarks>Note that the ContainerBuilder parameter is unique to this module.</remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Repository<AddressEntity, Guid>>().As<IRepository<AddressEntity, Guid>>().InstancePerLifetimeScope();
            builder.RegisterType<Repository<CityEntity, int>>().As<IRepository<CityEntity, int>>().InstancePerLifetimeScope();
            builder.RegisterType<Repository<CountryEntity, int>>().As<IRepository<CountryEntity, int>>().InstancePerLifetimeScope();
            builder.RegisterType<Repository<CountyEntity, int>>().As<IRepository<CountyEntity, int>>().InstancePerLifetimeScope();
            builder.RegisterType<Repository<StateEntity, int>>().As<IRepository<StateEntity, int>>().InstancePerLifetimeScope();
        }
    }
}