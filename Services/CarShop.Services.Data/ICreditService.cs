namespace CarShop.Services.Data
{
    using System.Threading.Tasks;

    using CarShop.Web.ViewModels.Credits;

    public interface ICreditService
    {
        Task CreateAsync(CreateCreditViewModel input, string userId);

        T GetById<T>(int id);
    }
}
