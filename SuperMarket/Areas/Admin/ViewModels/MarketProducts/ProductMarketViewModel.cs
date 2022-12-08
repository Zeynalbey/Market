using SuperMarket.Database.Models;

namespace SuperMarket.Areas.Admin.ViewModels.MarketProducts
{
    public class ProductMarketViewModel
    {
        public ProductMarketViewModel(int marketId, int productId, Market? market, Product? product)
        {
            MarketId = marketId;
            ProductId = productId;
            Market = market;
            Product = product;
        }

        public int MarketId { get; set; }
        public int ProductId { get; set; }
        public Market? Market { get; set; }
        public Product? Product { get; set; }

    }
}
