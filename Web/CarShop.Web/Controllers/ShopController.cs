﻿namespace CarShop.Web.Controllers
{
    using System.Threading.Tasks;

    using CarShop.Data.Models;
    using CarShop.Services.Data;
    using CarShop.Web.ViewModels.Shop;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class ShopController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IShopService shopService;

        public ShopController(UserManager<ApplicationUser> userManager, IShopService shopService)
        {
            this.userManager = userManager;
            this.shopService = shopService;
        }

        public IActionResult RedirectTo()
        {
            return this.View();
        }

        public IActionResult All()
        {
            return this.View();
        }

        public IActionResult Points()
        {
            var userName = this.User.Identity.Name;
            var viewModel = new ByIdPointsViewModel()
            {
                UserName = userName,
                PointsCount = 1,
            };
            return this.View(viewModel);
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Add(AddItemShopInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.shopService.AddAsync(input, user.UserName);

            this.TempData["SuccsessfulAddProductItem"] = "You sucsessfully add NEW product!";
            return this.RedirectToAction("All", "Shop", new { area = string.Empty });
        }
    }
}
