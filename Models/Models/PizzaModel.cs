using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("pizza_list")]
    public sealed class PizzaModel
    {
        [Key]
        [Required]
        [Column("pizza_list_id")]
        public Guid PizzaId { get; set; }

        [Required]
        [Column("image")]
        public string Image { get; set; } = string.Empty;
        
        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("description")]
        public string Description { get; set; } = string.Empty;

        // public string Ingredients { get; set; } = string.Empty;
        // public bool[]? AvailableSizes { get; set; }
        // public bool[]? AvailableThickness { get; set; }
        
        [Required]
        [Column("selected_size")]
        public int SelectedSize { get; set; }
        
        [Required]
        [Column("selected_thiknes")]
        public int SelectedThiknes { get; set; }
        
        [Required]
        [Column("price")]
        public double Price { get; set; }
        
        [Required]
        [Column("mass")]
        public double Mass { get; set; }
        
        [Required]
        [Column("is_half")]
        public bool IsHalf { get; set; }
        
        [Required]
        [Column("is_available_thicknes")]
        public bool IsAvailableThickness { get; set; }

        public List<ProductsModel>? Products { get; set; }
    }
}
