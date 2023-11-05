using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BikeShop.Models;

namespace BikeShop.ViewModels
{
    public class ViewProduct
    {

        public int? Id { get; set; }

        public string? name { get; set; }

        public int brand_id { get; set; }

        public int category_id { get; set; }

        public int model_year { get; set; }

        public decimal price { get; set; }


        public ViewProduct(Product product)
        {
            Id = product.Id;
            name=product.name;
            brand_id = product.brand_id;
            category_id = product.category_id;
            model_year = product.model_year;
            price = product.price;
        }
    }
}
