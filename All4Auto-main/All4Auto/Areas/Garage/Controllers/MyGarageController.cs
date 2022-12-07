namespace All4Auto.Areas.Garage.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    public class MyGarageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
