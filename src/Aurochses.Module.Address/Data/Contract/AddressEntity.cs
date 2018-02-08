using System;
using Aurochses.Data.EntityFrameworkCore;

namespace Aurochses.Module.Address.Data.Contract
{
    /// <summary>
    /// Class AddressEntity.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.Entity{Guid}" />
    public class AddressEntity : Entity<Guid>
    {
        // todo: add fields

        // todo: add DbGeography Location field https://github.com/aspnet/EntityFrameworkCore/issues/1100
    }
}