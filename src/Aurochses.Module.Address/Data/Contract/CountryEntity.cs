using Aurochses.Data.EntityFrameworkCore;

namespace Aurochses.Module.Address.Data.Contract
{
    /// <summary>
    /// Class CountryEntity.
    /// </summary>
    /// <seealso cref="Aurochses.Data.EntityFrameworkCore.EntityNoneDatabaseGeneratedIdentifier{Int}" />
    public class CountryEntity : EntityNoneDatabaseGeneratedIdentifier<int>
    {
        /// <summary>
        /// Gets or sets the two digits alphabetic code.
        /// </summary>
        /// <value>The two digits alphabetic code.</value>
        public string TwoDigitsAlphabeticCode { get; set; }

        /// <summary>
        /// Gets or sets the three digits alphabetic code.
        /// </summary>
        /// <value>The three digits alphabetic code.</value>
        public string ThreeDigitsAlphabeticCode { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        // todo: add DbGeography Location field https://github.com/aspnet/EntityFrameworkCore/issues/1100
    }
}