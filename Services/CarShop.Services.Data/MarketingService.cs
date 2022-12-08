namespace CarShop.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;
    using CarShop.Web.ViewModels.Marketing;

    public class MarketingService : IMarketingService
    {
        private readonly IDeletableEntityRepository<Marketing> marketingRepository;

        public MarketingService(IDeletableEntityRepository<Marketing> marketingRepository)
        {
            this.marketingRepository = marketingRepository;
        }

        public async Task CreateAsynk(CreateEmailMarketingViewModel input, string userId)
        {
            var marketing = new Marketing
            {
                Title = input.Title,
                Description = input.Description,
                CreatedByUserId = userId,
            };

            await this.marketingRepository.AddAsync(marketing);
            await this.marketingRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var marketingIdDelete = this.marketingRepository.All().FirstOrDefault(c => c.Id == id);
            this.marketingRepository.Delete(marketingIdDelete);
            await this.marketingRepository.SaveChangesAsync();
        }

        public IEnumerable<MarketingInListViewModel> GetAll()
        {
            var marketings = this.marketingRepository.AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .To<MarketingInListViewModel>()
                .ToList();

            return marketings;
        }

        public int GetCount()
        {
            return this.marketingRepository.AllAsNoTracking().Count();
        }
    }
}
