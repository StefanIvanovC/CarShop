namespace CarShop.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;
    using CarShop.Web.ViewModels.Credits;

    public class CreditService : ICreditService
    {
        private readonly IDeletableEntityRepository<Credit> creditRepository;

        public CreditService(IDeletableEntityRepository<Credit> creditRepository)
        {
            this.creditRepository = creditRepository;
        }

        public async Task CreateAsync(CreateCreditViewModel input, string userId)
        {
            var credit = new Credit
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                TotalMoney = input.TotalMoney,
                MonthPeriod = input.MonthPeriod,
                CreatedByUserId = userId,
            };

            await this.creditRepository.AddAsync(credit);
            await this.creditRepository.SaveChangesAsync();
        }

        public T GetById<T>(int id)
        {
            var credit = this.creditRepository.AllAsNoTracking()
                .Where(c => c.Id == id)
                .To<T>().FirstOrDefault();

            return credit;
        }
    }
}
