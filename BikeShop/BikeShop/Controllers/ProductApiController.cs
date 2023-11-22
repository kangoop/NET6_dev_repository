using BikeShop.Data;
using BikeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;

namespace BikeShop.Controllers
{
    [Route("api/Product/")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {

        private readonly ProductionDbContext _productionDbContext;


        public ProductApiController(ProductionDbContext productionDbContext)
        {
            this._productionDbContext = productionDbContext;
        }

        [Route("category")]
        [HttpPost]
        public IActionResult PostBikeCategory([FromBody] JsonElement category)
        {
            var maxcategory = _productionDbContext.categories.Max(category => category.Id);

            if (maxcategory == null)
            {
                maxcategory = 1;
            }
            else
            {
                maxcategory++;
            }


            string category_string = System.Text.Json.JsonSerializer.Serialize(category); // net6 의 system.text.json 은 데이터를 전송할때 오류를 발생 시킴으로 JsonElement 으로 변환 다시 string 형식으로 변환 

            var json_category = JObject.Parse(category_string);

            string category_name = json_category.Value<string?>("name");

            int result_row;
            Category new_category = new Category() { Id = maxcategory, name = category_name };
            _productionDbContext.categories.Add(new_category);
            result_row = _productionDbContext.SaveChanges();


            if (result_row >0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }         
        }


        [Route("brand")]
        [HttpPost]
        public IActionResult PostBikeBrand([FromBody] JsonElement brand)
        {
            var maxbrandname = _productionDbContext.brands.Max(Brand => Brand.Id);

            if (maxbrandname == null)
            {
                maxbrandname = 1;
            }
            else
            {
                maxbrandname++;
            }


            string brand_string = System.Text.Json.JsonSerializer.Serialize(brand); // net6 의 system.text.json 은 데이터를 전송할때 오류를 발생 시킴으로 JsonElement 으로 변환 다시 string 형식으로 변환 

            var json_category = JObject.Parse(brand_string);

            string category_name = json_category.Value<string?>("name");

            int result_row;
            Brand new_brand = new Brand() { Id = maxbrandname, name= category_name };
            _productionDbContext.brands.Add(new_brand);
            result_row = _productionDbContext.SaveChanges();
            //ID 직접 입력 이 불가능해서 적용한것 


            if (result_row > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }


        }
    }
}
