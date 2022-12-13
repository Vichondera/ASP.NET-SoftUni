namespace All4Auto.Api.Controllers
{
    using All4Auto.Core.Contracts;
    using All4Auto.Core.Models.Vehicle;
    using All4Auto.DataProcessor.Models.Vehicles;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService vehicleService;
        private readonly ILogger<VehicleController> logger;
        public VehicleController(
            IVehicleService _vehicleService,
            ILogger<VehicleController> _logger)
        {
            vehicleService = _vehicleService;
            logger = _logger;
        }

        /// <summary>
        /// get brand and models by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View</returns>
        [HttpGet]
        public async Task<IEnumerable<CarBrandView>> BrandById(int id)
        {
            var brand = await vehicleService.GetBrandById(id);
            var result = brand.Select(b => new CarBrandView()
            {
                Id = b.Id,
                Name = b.Name,
                BrandModels = b.BrandModels
            });
            return result;
        }

    }
}
