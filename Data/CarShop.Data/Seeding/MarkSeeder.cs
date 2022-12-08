namespace CarShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Models;

    public class MarkSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Marks.Any())
            {
                return;
            }

            await dbContext.Marks.AddAsync(new Mark { Name = "Audi" });
            await dbContext.Marks.AddAsync(new Mark { Name = "VW" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mercedes" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Toyota" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Tesla" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Jaguar" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lada" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Dacia" });

            await dbContext.SaveChangesAsync();
        }
    }
}
