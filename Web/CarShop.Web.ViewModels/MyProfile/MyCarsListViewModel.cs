namespace CarShop.Web.ViewModels.MyProfile
{
    using System.Collections.Generic;

    public class MyCarsListViewModel
    {
        public IEnumerable<MyCarsInListViewModel> Cars { get; set; }
    }
}
