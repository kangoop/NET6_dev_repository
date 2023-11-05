using BikeShop.Data;
using BikeShop.Models;
using BikeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    [Route("/[controller]/[action]")]
    public class ProductController : Controller
    {

        private readonly IHttpContextAccessor _HttpContextAccessor;

        private readonly ProductionDbContext _productionDbContext;

        public ProductController(IHttpContextAccessor httpcontextaccessor,ProductionDbContext productionDbContext)
        {
            _HttpContextAccessor= httpcontextaccessor;
            _productionDbContext= productionDbContext;
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

            var categories = _productionDbContext.categories.ToList();

            var brands = _productionDbContext.brands.ToList();

            ViewData[nameof(Category)] = categories;
            ViewData[nameof(Brand)] = brands;

            return View();
        }

        public IActionResult options()
        {
            return View();
        }
    }
}
