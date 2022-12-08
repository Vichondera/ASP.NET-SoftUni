using Microsoft.AspNetCore.Mvc;

namespace All4Auto.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
