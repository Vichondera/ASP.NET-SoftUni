namespace All4Auto.Core.Contracts
{
    using All4Auto.Core.Models.Vehicle;
    /// <summary>  Access data from db  </summary>
    public interface IVehicleService
    {
        /// <summary>
        /// Get All Car Makes from DB
        /// </summary>
        /// <returns>List Car Brands in db</returns>
        Task<IEnumerable<CarBrandView>> GetAllBrands();

        /// <summary>
        /// Get Brand By Given Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List w searched Brand</returns>
        Task<IEnumerable<CarBrandView>> GetBrandById(int id);
    }
}
