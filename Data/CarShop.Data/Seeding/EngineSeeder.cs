namespace CarShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Models;

    public class EngineSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Engines.Any())
            {
                return;
            }

            await dbContext.Engines.AddAsync(new Engine { Type = "Disel" });
            await dbContext.Engines.AddAsync(new Engine { Type = "Gasoline" });
            await dbContext.Engines.AddAsync(new Engine { Type = "Electric" });
            await dbContext.Engines.AddAsync(new Engine { Type = "Hibrid" });

            await dbContext.SaveChangesAsync();
        }
    }
}
