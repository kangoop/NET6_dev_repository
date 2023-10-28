using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeShop.Models
{
    public class Category
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(255)")]
        public string? name { get; set; }
    }
}
