using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    [Table("pizza_and_products")]
    public sealed class PizzaAndProductsModel
    {
        [Key]
        [Required]
        [Column("id")]
        public Guid PizzaAndProductsId { get; set; }

        [Required]
        [Column("pizza_id")]
        public Guid PizzaId { get; set; }
        public List<PizzaModel>? PizzaModels { get; set; }

        [Required]
        [Column("product_id")]
        public Guid ProductId { get; set; }

        public List<ProductsModel>? Products { get; set; }
        public List<PizzaModel>? Pizza { get; set; }
    }
}
