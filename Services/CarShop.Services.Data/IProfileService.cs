namespace CarShop.Services.Data
{
    using System.Collections.Generic;

    using CarShop.Web.ViewModels.MyProfile;

    public interface IProfileService
    {
        IEnumerable<MyCarsInListViewModel> MyCars(string userId);
    }
}
