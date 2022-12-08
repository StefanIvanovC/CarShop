namespace CarShop.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using CarShop.Data.Models;
    using CarShop.Services.Data;
    using CarShop.Web.ViewModels.Cars;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : Controller
    {
        private readonly ICarService carService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public CarsController(ICarService carService, UserManager<ApplicationUser> userManager, IWebHostEnvironment environment)
        {
            this.carService = carService;
            this.userManager = userManager;
            this.environment = environment;
        }

        public UserManager<ApplicationUser> UserManager { get; }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateCarViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);

            try
            {
                await this.carService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                return this.View(input);
            }

            this.TempData["SuccsessfulCarPostCreate"] = "You sucsessfully create car post!";
            return this.RedirectToAction("MyProfile", "Profiles", new { area = string.Empty });
        }

        public IActionResult All(int id = 1)
        {
            const int itemsPerPage = 9;
            var viewModel = new CarListViewModel()
            {
                PageNumber = id,
                Cars = this.carService.GetAll(id, 9),
                CarCount = this.carService.GetCount(),
                ItemsPerPage = itemsPerPage,
            };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var car = this.carService.GetById<ByIdCarViewModel>(id);
            return this.View(car);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.carService.DeleteAsync(id);
            this.TempData["SuccsessfulDeleteCarPost"] = "Your succsesfully delete your post!";
            return this.RedirectToAction(nameof(this.All));
        }
    }
}
