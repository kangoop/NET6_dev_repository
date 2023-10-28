using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string? name { get; set; }
        [Required]
        public int brand_id { get; set; }
        [Required]
        public int category_id { get; set; }
        [Required]
        public int model_year { get; set; }

        [Column(TypeName ="decimal(10, 2)")]
        public decimal price { get; set; }
    }
}
