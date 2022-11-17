namespace TestTask.Models
{
    public sealed class PizzaDataModel
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string[]? Ingredients { get; set; }
        public int SelectedSize { get; set; }
        public bool[]? AvailableSizes { get; set; }
        public int SelectedThiknes { get; set; }
        public bool[]? AvailableThickness { get; set; }
        public double Price { get; set; }
        public double Mass { get; set; }
        public bool IsHalf { get; set; }
        public bool IsAvailableThickness { get; set; }
    }
}
