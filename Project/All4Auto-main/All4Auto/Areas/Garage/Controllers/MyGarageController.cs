using Microsoft.AspNetCore.Mvc;

namespace All4Auto.Areas.Garage.Controllers
{
    public class MyGarageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
