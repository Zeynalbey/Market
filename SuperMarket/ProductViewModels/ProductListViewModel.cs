namespace SuperMarket.ProductViewModels
{
    public class ProductListViewModel
    {
        public string Market { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

        public ProductListViewModel(string market, int id, string name, decimal price,  DateTime createdAt)
        {
            Market = market;
            Id = id;
            Name = name;
            Price = price;
            CreatedAt = createdAt;

        }
    }
}
