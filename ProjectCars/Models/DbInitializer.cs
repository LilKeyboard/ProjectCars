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
                    new Car {Make = "Ford", Model = "Mustang", YearOfProduction = 2016, Mileage = "34 000 km", Engine = "4 900 cm3", Fuel = "benzyna", HorsePower = "421 KM", Description = "Mam do sprzedania Mustanga 5.0 GT V8 421KM. Kupiony w Polskim SALONIE FORDA w Opolu jako NOWY w kwietniu 2016", Price = 160000M, PhotoUrl = "/images/fordMustang.jpg", MiniPhotoUrl = "/images/fordMustang.jpg" },
                    new Car {Make = "Audi", Model = "S5", YearOfProduction = 2013, Mileage = "112 000 km", Engine = "3 000 cm3", Fuel = "benzyna", HorsePower = "280 KM", Description = "Do sprzedania Audi S5 z 2013 roku. Jestem właścicielem tego samochodu od ponad dwóch lat.", Price = 115000M, PhotoUrl = "/images/audiS5.jpg", MiniPhotoUrl = "/images/audiS5.jpg" },
                    new Car {Make = "BMW", Model = "X4", YearOfProduction = 2017, Mileage = "4 300 km", Engine = "1 995 cm3", Fuel = "benzyna", HorsePower = "190 KM", Description = "BMV X4 20d xDrive. Samochód krajowy. Samochód serwisowany. Wystawiamy fakturę VAT 23%. Samochód bezwypadkowy. I właściciel.", Price = 194000M, PhotoUrl = "/images/bmvx4.jpg", MiniPhotoUrl = "/images/bmvx4.jpg" },
                    new Car {Make = "Chevrolet", Model = "Corvette", YearOfProduction = 1972, Mileage = "28 000 km", Engine = "5 700 cm3", Fuel = "benzyna", HorsePower = "300 KM", Description = "Corvetta jest w świetnym stanie wizualnym i mechanicznym. Oczywiście jest ZAREJESTROWANA i ubezpieczona w PL.", Price = 90000M, PhotoUrl = "/images/chevroletCorvete.jpg", MiniPhotoUrl = "/images/chevroletCorvete.jpg" },
                    new Car {Make = "Nissan", Model = "Skyline", YearOfProduction = 1995, Mileage = "144 000 km", Engine = "2 500 cm3", Fuel = "benzyna", HorsePower = "410 KM", Description = "Na sprzedaż trafia moja perełka Nissan Skyline R33.Auto z Japonii sprowadzone do Szwecji, gdzie było przez wiele lat modyfikowane, uczestniczyło w zlotach, zdobywało nagrody, samochód sponsorowany latami przez Sonax Sweden.", Price = 120000M, PhotoUrl = "/images/nissan.jpg", MiniPhotoUrl = "/images/nissan.jpg" },
                    new Car {Make = "Jaguar", Model = "ZX", YearOfProduction = 2006, Mileage = "78000 km", Engine = "5 000 cm3", Fuel = "benzyna", HorsePower = "510 KM", Description = "Przedstawiam Państwu wyjątkowe auto jakim jest Jaguar XKR, a zwłaszcza ten egzemplarz. Jaguar XKR to ikona światowej i brytyjskiem motoryzacji, a przede wszystkim kontynuator legendarnego już Jaguara E-typa, przez wielu uważany za najpiękniejsze auto w historii motoryzacji.", Price = 200000M, PhotoUrl = "/images/jaguar.jpg", MiniPhotoUrl = "/images/jaguar.jpg" }
                    );
            }

            context.SaveChanges();
        }
    }
}
