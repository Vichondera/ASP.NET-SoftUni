namespace All4Auto.Areas.Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Area("Shop")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
