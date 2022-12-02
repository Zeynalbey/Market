using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperMarket.Database;
using SuperMarket.ProductViewModels;
using SuperMarket.Services.Abstracts;
using System.Linq;

namespace SuperMarket.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;
        //private readonly IEmailService _emailService;


        public ProductController(DataContext dataContext/*, IEmailService emailService*/)
        {
            _dataContext = dataContext;
            //_emailService = emailService;
        }


        //[HttpGet("list", Name ="product-list")]
        //public async Task <IActionResult> ListAsync()
        //{
        //    var model = await _dataContext.Products
        //        .Select(p => new ProductListViewModel($"{p.Market.Name}", p.Id, p.Name, p.Price, p.CreatedAt))
        //        .ToListAsync();

        //    return View("~/Views/Product/List.cshtml" , model);
        //}













    }
}
