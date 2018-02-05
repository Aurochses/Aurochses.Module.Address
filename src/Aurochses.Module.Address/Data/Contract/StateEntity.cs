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
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }
    }
}