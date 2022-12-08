namespace CarShop.Web.ViewModels.Marketing
{
    using System;

    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class MarketingInListViewModel : IMapFrom<Marketing>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserUserName { get; set; }
    }
}
