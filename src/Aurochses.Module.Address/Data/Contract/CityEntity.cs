using Aurochses.Data.EntityFrameworkCore;

namespace Aurochses.Module.Address.Data.Contract
{
    /// <summary>
    /// Class CityEntity.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.Entity{Int}" />
    public class CityEntity : Entity<int>
    {
        /// <summary>
        /// Gets or sets the county identifier.
        /// </summary>
        /// <value>The county identifier.</value>
        public int CountyId { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        // todo: add DbGeography Location field https://github.com/aspnet/EntityFrameworkCore/issues/1100

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>The county.</value>
        public virtual CountyEntity County { get; set; }
    }
}