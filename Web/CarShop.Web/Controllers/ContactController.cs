namespace CarShop.Web.Controllers
{
    using System.Threading.Tasks;

    using CarShop.Data.Models;
    using CarShop.Services.Data;
    using CarShop.Web.ViewModels.Contacts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : Controller
    {
        private readonly IQuestionService questionService;
        private readonly UserManager<ApplicationUser> userManager;

        public ContactController(IQuestionService questionService, UserManager<ApplicationUser> userManager)
        {
            this.questionService = questionService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(ContactInputFormModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.questionService.CreateAsynk(input, user.Id);

            this.TempData["SuccsessfulQuestionCreate"] = "You have successfully submitted your question!";
            return this.View();
        }
    }
}
