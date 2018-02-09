using Aurochses.Module.Address.Business.Contract;
using Aurochses.Module.Address.Data.Contract;

namespace Aurochses.Module.Address.Business
{
    /// <summary>
    /// Class AddressService.
    /// </summary>
    /// <seealso cref="IAddressService" />
    public class AddressService : IAddressService
    {
        private readonly IAddressUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        public AddressService(IAddressUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}