using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
