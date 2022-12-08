namespace CarShop.Web.Controllers
{
    using System.Threading.Tasks;

    using CarShop.Data.Models;
    using CarShop.Services.Data;

    using CarShop.Web.ViewModels.Credits;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CreditsController : Controller
    {
        private readonly ICreditService creditService;
        private readonly UserManager<ApplicationUser> userManager;

        public CreditsController(ICreditService creditService, UserManager<ApplicationUser> userManager)
        {
            this.creditService = creditService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreateCreditViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.creditService.CreateAsync(input, user.Id);

            this.TempData["SuccsessfulApplyingForCredit"] = "You sucsessfully apply for credit!";
            return this.RedirectToAction($"ById");
        }

        [Authorize]
        public IActionResult ById(int id)
        {
            var credit = this.creditService.GetById<CreditByIdViewModel>(id);
            return this.View(credit);
        }
    }
}
