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
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }
    }
}