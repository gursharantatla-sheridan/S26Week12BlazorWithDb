namespace S26Week12BlazorWithDb.Models
{
    public class Product
    {
        // scalar properties
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double? Price { get; set; }
        public int? CategoryId { get; set; }

        // navigation property
        public Category? Category { get; set; }
    }
}
