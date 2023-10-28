using BikeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {

        [Route("[controller]")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
