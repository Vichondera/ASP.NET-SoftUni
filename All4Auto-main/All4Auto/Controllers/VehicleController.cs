using All4Auto.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace All4Auto.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleService;

        public VehicleController(IVehicleService _vehicleService)
        {
            vehicleService= _vehicleService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async  Task<IActionResult> Brands()
        {
            var brands = await vehicleService.GetAllBrands();
            
            return View(brands);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> BrandById()
        {
            /*  var routeValues = Url.ActionContext.RouteData.Values;
              stringparamName = "id";
              string? id = routeValues[paramName];
              var b = await vehicleService.GetBrandById(id);*/
            var id = 5;
            var brand = await vehicleService.GetBrandById(id);
            return View(brand);
        }
    }
}
