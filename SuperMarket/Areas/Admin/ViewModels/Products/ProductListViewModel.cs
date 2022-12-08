using SuperMarket.Database.Models;

namespace SuperMarket.Areas.Admin.ViewModels.Products
{
    public class ProductListViewModel
    {
        public string Category { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public List<MarketViewModel>? Markets { get; set; }
       


        public ProductListViewModel(string category,int id, string name, decimal price, DateTime createdAt, DateTime updatedAt, bool isActive)
        {
            Id = id;
            Name = name;
            Price = price;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            IsActive = isActive;
            Category = category;

        }

      
    }
    public class MarketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductListViewModel> Products { get; set; }


        public MarketViewModel(int id, string name, List<ProductListViewModel> products)
        {
            Id = id;
            Name = name;
            Products = products;
        }

    }
}
