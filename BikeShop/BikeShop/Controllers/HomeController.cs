using BikeShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    [Route("/[controller]/[action]")]
    public class HomeController : Controller
    {

        private readonly ProductionDbContext _productionDbContext;

        public HomeController(ProductionDbContext productionDbContext)
        {
            this._productionDbContext = productionDbContext;
        }

        [Route("/")]
        [Route("/[controller]")]
        [Route("/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
