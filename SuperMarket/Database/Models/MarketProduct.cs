using Microsoft.EntityFrameworkCore;

namespace SuperMarket.Database.Models
{
    public class MarketProduct
    {
        public int MarketId { get; set; }
        public int ProductId { get; set; }
        public Market Market { get; set; }
        public Product Product { get; set; }
    }
}
