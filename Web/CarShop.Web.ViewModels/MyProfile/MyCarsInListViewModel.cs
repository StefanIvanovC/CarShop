namespace CarShop.Web.ViewModels.MyProfile
{
    using System;

    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class MyCarsInListViewModel : IMapFrom<Car>
    {
        public string CreatedByUserUserName { get; set; }

        public string MarkName { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
