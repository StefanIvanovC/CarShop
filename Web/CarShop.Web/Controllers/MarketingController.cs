namespace CarShop.Web.Controllers
{
    using System.Threading.Tasks;

    using CarShop.Data.Models;
    using CarShop.Services.Data;
    using CarShop.Web.ViewModels.Marketing;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class MarketingController : Controller
    {
        private readonly IMarketingService marketingService;
        private readonly UserManager<ApplicationUser> userManager;

        public MarketingController(IMarketingService marketingService, UserManager<ApplicationUser> userManager)
        {
            this.marketingService = marketingService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateEmailMarketingViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.marketingService.CreateAsynk(input, user.Id);

            this.TempData["SuccsessfulEmailMarketingPostCreate"] = "You sucsessfully send emails to all registrated users!";
            return this.RedirectToAction("All", "Marketing", new { area = string.Empty });
        }

        [Authorize]
        public IActionResult All()
        {
            var model = new MarketingListViewModel()
            {
                Marketings = this.marketingService.GetAll(),
                Count = this.marketingService.GetCount(),
            };

            return this.View(model);
        }

        [Authorize]
        public IActionResult RedirectTo()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            await this.marketingService.DeleteAsync(id);
            this.TempData["SuccsessfulDeleteMarketingHistory"] = "Your succsesfully delete your marketing History!";
            return this.RedirectToAction(nameof(this.All));
        }
    }
}
