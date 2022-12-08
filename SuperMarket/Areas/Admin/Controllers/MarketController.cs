using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperMarket.Areas.Admin.ViewModels.Markets;
using SuperMarket.Areas.Admin.ViewModels.Products;
using SuperMarket.Database;

namespace SuperMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("market")]
    public class MarketController : Controller
    {
        private readonly DataContext _dataContext;
        public MarketController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet("list", Name ="market-list")]
        public IActionResult List()
        {
            var model = _dataContext.Markets.Select(m => new MarketOnlyListViewModel(m.Id, m.Name)).ToList();
            return View(model);
        }

        [HttpPost("delete/{id}",Name ="market-delete")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            var market = await _dataContext.Markets.FirstOrDefaultAsync(m => m.Id == id);
            
            if (market == null)
            {
                return NotFound();
            }

            _dataContext.Markets.Remove(market);
            await _dataContext.SaveChangesAsync();


            return RedirectToRoute("market-list");
        }
    }
}
