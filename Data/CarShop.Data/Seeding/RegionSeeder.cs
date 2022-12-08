﻿namespace CarShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Models;

    public class RegionSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Regions.Any())
            {
                return;
            }

            await dbContext.Regions.AddAsync(new Region { Name = "Blagoevgrad" });
            await dbContext.Regions.AddAsync(new Region { Name = "Burgas" });
            await dbContext.Regions.AddAsync(new Region { Name = "Varna" });
            await dbContext.Regions.AddAsync(new Region { Name = "Veliko Turnovo" });
            await dbContext.Regions.AddAsync(new Region { Name = "Vidin" });
            await dbContext.Regions.AddAsync(new Region { Name = "Vratca" });
            await dbContext.Regions.AddAsync(new Region { Name = "Gabrovo" });
            await dbContext.Regions.AddAsync(new Region { Name = "Karjali" });
            await dbContext.Regions.AddAsync(new Region { Name = "Kustendil" });
            await dbContext.Regions.AddAsync(new Region { Name = "Lovech" });
            await dbContext.Regions.AddAsync(new Region { Name = "Montana" });
            await dbContext.Regions.AddAsync(new Region { Name = "Pazardjic" });
            await dbContext.Regions.AddAsync(new Region { Name = "Pernik" });
            await dbContext.Regions.AddAsync(new Region { Name = "Pleven" });
            await dbContext.Regions.AddAsync(new Region { Name = "Plovdiv" });
            await dbContext.Regions.AddAsync(new Region { Name = "Razgrad" });
            await dbContext.Regions.AddAsync(new Region { Name = "Ruse" });
            await dbContext.Regions.AddAsync(new Region { Name = "Sliven" });
            await dbContext.Regions.AddAsync(new Region { Name = "Silistra" });
            await dbContext.Regions.AddAsync(new Region { Name = "Smolqn" });
            await dbContext.Regions.AddAsync(new Region { Name = "Sofiq" });
            await dbContext.Regions.AddAsync(new Region { Name = "Stara Zagora" });
            await dbContext.Regions.AddAsync(new Region { Name = "Tyrgovishte" });
            await dbContext.Regions.AddAsync(new Region { Name = "Haskovo" });
            await dbContext.Regions.AddAsync(new Region { Name = "Shumen" });
            await dbContext.Regions.AddAsync(new Region { Name = "Qmbol" });

            await dbContext.SaveChangesAsync();
        }
    }
}
