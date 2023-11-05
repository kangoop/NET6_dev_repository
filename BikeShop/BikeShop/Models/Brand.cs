using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeShop.Models
{
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //key 에서 자동 증가 옵션을 해제 하는
        public int? Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string? Name { get; set; }
    }
}
