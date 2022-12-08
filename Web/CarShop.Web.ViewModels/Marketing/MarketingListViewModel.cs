namespace CarShop.Web.ViewModels.Marketing
{
    using System.Collections.Generic;

    public class MarketingListViewModel
    {
        public IEnumerable<MarketingInListViewModel> Marketings { get; set; }

        public int Count { get; set; }
    }
}
