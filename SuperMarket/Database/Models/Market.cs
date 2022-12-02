namespace SuperMarket.Database.Models
{
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MarketProduct>? MarketProducts { get; set; }
    }
}
