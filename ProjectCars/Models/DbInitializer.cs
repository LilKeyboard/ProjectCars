using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCars.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cars.Any())
            {
                context.AddRange(
                    new Car { Make = "Audi", Model = "RS3 Sportback", YearOfProduction = 2019, Mileage = " 10 km", Engine = "2 500 cm3", Fuel = "benzyna", HorsePower = "395 KM", Description = "Jeden z najszybszych hot-hatchów na świecie. ", Price = 200000M, MiniPhotoUrl = "/images/rs3_1.jpg", PhotoUrl1 = "/images/rs3_1.jpg", PhotoUrl2 = "/images/rs3_2.jpg", PhotoUrl3 = "/images/rs3_3.jpg", PhotoUrl4 = "/images/rs3_4.jpg" },
                    new Car { Make = "Audi", Model = "RS3 Sportback", YearOfProduction = 2019, Mileage = " 10 km", Engine = "2 500 cm3", Fuel = "benzyna", HorsePower = "395 KM", Description = "Jeden z najszybszych hot-hatchów na świecie. ", Price = 200000M, MiniPhotoUrl = "/images/rs3_1.jpg", PhotoUrl1 = "/images/rs3_1.jpg", PhotoUrl2 = "/images/rs3_2.jpg", PhotoUrl3 = "/images/rs3_3.jpg", PhotoUrl4 = "/images/rs3_4.jpg" }

                    );
            }

            context.SaveChanges();
        }
    }
}
