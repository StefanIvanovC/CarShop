namespace CarShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Models;

    public class ExtraSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Extras.Any())
            {
                return;
            }

            await dbContext.Extras.AddAsync(new Extra {Name = "360-degree parking camera" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Four-wheel drive (4WD)" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Adaptive LED headlights" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Folding mirrors" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Heated steering wheel" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Adaptive cruise control" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Remote parking" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Antilock Brakes" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Electronic Stability Control" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Adaptive Headlights" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Traction Control" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Security Alarm System" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Dash CameraDash Camera" });
            await dbContext.Extras.AddAsync(new Extra { Name = "GPS Indicator" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Leather seats" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Sunroof/moonroof" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Heated seats" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Backup camera" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Navigation system" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Bluetooth" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Remote start" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Blind spot monitoring" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Third-row seating" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Apple CarPlay/Android Auto" });
            await dbContext.SaveChangesAsync();
        }
    }
}
