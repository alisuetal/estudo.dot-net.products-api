using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("tb_product")]
    public class Product : BaseEntity
    {
        [Column("nm_product")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Column("vl_price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }
        [Column("ds_product")]
        [StringLength(500)]
        public string Description { get; set; }
        [Column("nm_category")]
        [StringLength(50)]
        public string Category { get; set; }
        [Column("nm_img_url")]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
