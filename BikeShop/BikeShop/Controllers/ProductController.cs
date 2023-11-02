using BikeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    [Route("/[controller]/[action]")]
    public class ProductController : Controller
    {

        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ProductController(IHttpContextAccessor httpcontextaccessor)
        {
            _HttpContextAccessor= httpcontextaccessor;
        }

        [Route("/[controller]")]
        [Route("/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult bike()
        {
            var baseurl = _HttpContextAccessor.HttpContext?.Request;

            return View();
        }

        public IActionResult add()
        {
            var baseurl = _HttpContextAccessor.HttpContext?.Request.Host;

            ViewData["hosturl"] = baseurl;

            return View();
        }

        public IActionResult options()
        {
            return View();
        }
    }
}
