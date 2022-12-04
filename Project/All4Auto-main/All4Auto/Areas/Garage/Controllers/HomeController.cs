using Microsoft.AspNetCore.Mvc;

namespace All4Auto.Areas.Garage.Controllers
{
    [Area("Garage")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
