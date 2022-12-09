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

            await dbContext.Marks.AddAsync(new Mark { Name = "Abarth" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Acura" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Aixam" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Alfa Romeo" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Alpina" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Aro" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Asia" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Aston martin" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Audi" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Austin" });
            await dbContext.Marks.AddAsync(new Mark { Name = "BMW" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Bentley" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Berliner" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Bertone" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Borgward" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Brilliance" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Bugatti" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Buick" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Cadillac" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Carbodies" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Chery" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Chevrolet" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Chrysler" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Citroen" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Corvette" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Cupra" });
            await dbContext.Marks.AddAsync(new Mark { Name = "DONGFENG" });
            await dbContext.Marks.AddAsync(new Mark { Name = "DS" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Dacia" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Daewoo" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Daihatsu" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Daimler" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Dodge" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Dr" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Eagle" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Ferrari" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Fiat" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Ford" });
            await dbContext.Marks.AddAsync(new Mark { Name = "GOUPIL" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Gaz" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Geely" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Genesis" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Geo" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Gmc" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Gonow" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Great Wall" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Haval" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Heinkel" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Hillman" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Honda" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Hummer" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Hyundai" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Ifa" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Infiniti" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Innocenti" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Isuzu" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Iveco" });
            await dbContext.Marks.AddAsync(new Mark { Name = "JAC" });
            await dbContext.Marks.AddAsync(new Mark { Name = "JAS" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Jaguar" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Jeep" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Jpx" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Kia" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lada" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Laforza" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lamborghini" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lancia" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Land Rover" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Landwind" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Lexus" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lifan" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lincoln" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Lotus" });
            await dbContext.Marks.AddAsync(new Mark { Name = "MG" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mahindra" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Maserati" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Matra" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Maybach" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mazda" });

            await dbContext.Marks.AddAsync(new Mark { Name = "McLaren" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mercedes-Benz" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mercury" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mg" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mini" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Mitsubishi" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Morgan" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Moskvich" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Nissan" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Opel" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Peugeot" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Pgo" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Pontiac" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Porsche" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Renault" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Rolls-Royce" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Rover" });
            await dbContext.Marks.AddAsync(new Mark { Name = "SECMA" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Saab" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Samand" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Santana" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Saturn" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Scion" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Seat" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Shatenet" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Shuanghuan" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Simca" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Skoda" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Smart" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Ssang Yong" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Subaru" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Suzuki" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Talbot" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Tata" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Tavria" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Tazzari" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Tempo" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Terberg" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Tesla" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Toyota" });

            await dbContext.Marks.AddAsync(new Mark { Name = "Trabant" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Triumph" });
            await dbContext.Marks.AddAsync(new Mark { Name = "VW" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Volga" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Volvo" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Warszawa" });
            await dbContext.Marks.AddAsync(new Mark { Name = "Wartburg" });

            await dbContext.SaveChangesAsync();
        }
    }
}
