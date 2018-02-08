using Aurochses.Data.EntityFrameworkCore;

namespace Aurochses.Module.Address.Data.Contract
{
    /// <summary>
    /// Class StateEntity.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.Entity{Int}" />
    public class StateEntity : Entity<int>
    {
        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>The country identifier.</value>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        // todo: add DbGeography Location field https://github.com/aspnet/EntityFrameworkCore/issues/1100

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        public virtual CountryEntity Country { get; set; }
    }
}