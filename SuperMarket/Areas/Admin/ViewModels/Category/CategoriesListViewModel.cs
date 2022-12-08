using SuperMarket.Database.Models;

namespace SuperMarket.Areas.Admin.ViewModels.Category
{
    public class CategoriesListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
