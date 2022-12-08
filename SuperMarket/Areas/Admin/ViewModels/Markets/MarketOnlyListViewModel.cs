namespace SuperMarket.Areas.Admin.ViewModels.Markets
{
    public class MarketOnlyListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MarketOnlyListViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
