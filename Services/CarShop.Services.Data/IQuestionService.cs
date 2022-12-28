namespace CarShop.Services.Data
{
    using System.Threading.Tasks;

    using CarShop.Web.ViewModels.Contacts;

    public interface IQuestionService
    {
        Task CreateAsynk(ContactInputFormModel input, string user);
    }
}
