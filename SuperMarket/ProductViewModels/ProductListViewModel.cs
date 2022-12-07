using SuperMarket.Database.Models;

namespace SuperMarket.ProductViewModels
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public List<MarketProduct>? MarketProducts { get; set; }


        public ProductListViewModel(int id, string name, decimal price, DateTime createdAt, DateTime updatedAt, bool isActive, List<string> list)
        {
            Id = id;
            Name = name;
            Price = price;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            IsActive = isActive;
        }
    }
}
