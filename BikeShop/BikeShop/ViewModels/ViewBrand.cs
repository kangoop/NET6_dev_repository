using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BikeShop.Models;

namespace BikeShop.ViewModels
{
    public class ViewBrand
    {
        public int? Id { get; set; }

        public string? Name { get; set; }


        public ViewBrand(Brand brand)
        {
            Id=brand.Id;
            Name=brand.name;
        }
    }
}
