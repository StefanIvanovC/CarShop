namespace CarShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Models;

    public class CarSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cars.Any())
            {
                return;
            }

            await dbContext.Cars.AddAsync(new Car { Price = 1000, Year = 1995 });
            await dbContext.SaveChangesAsync();
        }
    }
}
