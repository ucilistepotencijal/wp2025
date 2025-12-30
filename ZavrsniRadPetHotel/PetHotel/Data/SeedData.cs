using Microsoft.EntityFrameworkCore;
using PetHotel.Models;

namespace PetHotel.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Provjerava ima li već usluga u bazi, ako ima - ne radi ništa
                if (context.ServiceTypes.Any())
                {
                    return;
                }

                context.ServiceTypes.AddRange(
                    new ServiceType
                    {
                        Name = "Noćenje",
                        Description = "Standardno noćenje s hranom i tri šetnje dnevno.",
                        Price = 25.00M
                    },
                    new ServiceType
                    {
                        Name = "Vrtić (Daily Care)",
                        Description = "Dnevni boravak bez noćenja, idealno za zaposlene vlasnike.",
                        Price = 15.00M
                    },
                    new ServiceType
                    {
                        Name = "Kupanje i uređivanje",
                        Description = "Profesionalno kupanje, sušenje i češljanje ljubimca.",
                        Price = 20.00M
                    },
                    new ServiceType
                    {
                        Name = "VIP tretman",
                        Description = "Noćenje u deluxe apartmanu uz dodatne poslastice i igre.",
                        Price = 40.00M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}