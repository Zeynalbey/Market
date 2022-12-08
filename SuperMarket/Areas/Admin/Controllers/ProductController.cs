using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SuperMarket.Database;
using SuperMarket.Database.Models;
using SuperMarket.Areas.Admin.ViewModels;
using System.Linq;
using SuperMarket.Areas.Admin.ViewModels.MarketProducts;
using SuperMarket.Areas.Admin.ViewModels.Products;
using SuperMarket.Areas.Admin.ViewModels.MarketProducts;

namespace SuperMarket.Areas.Admin.Controllers     
{
    [Area("Admin")]
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

            var model2 = _dataContext.Markets.Select(m => new MarketViewModel(m.Id,m.Name,m.MarketProducts.Select(mp=> mp.Product)
                .Select(p=> new ProductListViewModel($"{p.Category.Name}",p.Id,p.Name,p.Price,p.CreatedAt,p.UpdatedAt,
                p.IsActive)).ToList())).ToList();
            return View(model2);
        } 

        //[HttpGet("add")]

        //public IActionResult Add()
        //{
        //    var model = new AddProductMarketViewModel
        //    {
        //        Markets = _dataContext.Markets.Select(m => new MarketViewModel(m.Id, m.Name)).ToList(),
        //        Products = _dataContext.Products.Select(p => new ProductListViewModel(p.Id, p.Name, p.Price, p.CreatedAt, p.UpdatedAt, p.IsActive)).ToList()
        //    };
        //    return View(model);
        //}

        //[HttpPost("add")]

        //public IActionResult Add(AddProductMarketViewModel model)
        //{

        //    var product = new Product
        //    {
        //        Name = model.Products[0].Name,
        //        Price = model.Products[0].Price,
        //        CreatedAt = DateTime.Now,
        //        UpdatedAt = DateTime.Now,
        //        IsActive = model.Products[0].IsActive

        //    };

        //    var Market = new Market
        //    {
        //        Name = model.Markets[0].Name
        //    };

        //    return View();
        //}
    }
}
