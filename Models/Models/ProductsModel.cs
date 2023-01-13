using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("products")]
    public sealed class ProductsModel
    {
        [Key]
        [Required]
        [Column("products_id")]
        public Guid ProductId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

    }
}
