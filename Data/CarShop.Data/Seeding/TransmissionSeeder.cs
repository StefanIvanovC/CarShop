namespace CarShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Models;

    public class TransmissionSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Transmissions.Any())
            {
                return;
            }

            await dbContext.Transmissions.AddAsync(new Transmission { Type = "Manual gearbox" });
            await dbContext.Transmissions.AddAsync(new Transmission { Type = "Automatic gearbox"});
            await dbContext.Transmissions.AddAsync(new Transmission { Type = "Semi-automatic gearbox" });

            await dbContext.SaveChangesAsync();
        }
    }
}
