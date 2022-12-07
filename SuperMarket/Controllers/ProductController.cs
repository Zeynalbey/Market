using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SuperMarket.Database;
using SuperMarket.Database.Models;
using SuperMarket.ProductViewModels;
using System.Linq;

namespace SuperMarket.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("list")]
        public IActionResult List()
        {

            var model = _dataContext.MarketProducts.Select(mp => new ProductMarketViewModel(mp.MarketId, mp.ProductId, mp.Market, mp.Product)).ToList();

           return View(model);
        }
    }
}
