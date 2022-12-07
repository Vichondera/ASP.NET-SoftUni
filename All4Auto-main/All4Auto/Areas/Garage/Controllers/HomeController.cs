namespace All4Auto.Areas.Garage.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    [Area("Garage")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
