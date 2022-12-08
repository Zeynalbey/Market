namespace SuperMarket.Database.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<MarketProduct>? MarketProducts { get; set; }

    }
}
