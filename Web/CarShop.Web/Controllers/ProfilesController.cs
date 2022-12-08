namespace CarShop.Web.Controllers
{
    using System.Security.Claims;

    using CarShop.Data.Models;
    using CarShop.Services.Data;
    using CarShop.Web.ViewModels.MyProfile;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class ProfilesController : Controller
    {
        private readonly IProfileService profileService;
        private readonly UserManager<ApplicationUser> userManager;

        public ProfilesController(IProfileService profileService, UserManager<ApplicationUser> userManager)
        {
            this.profileService = profileService;
            this.userManager = userManager;
        }

        public IActionResult MyProfile()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewModel = new MyCarsListViewModel
            {
                Cars = this.profileService.MyCars(userId),
            };
            return this.View(viewModel);
        }
    }
}
