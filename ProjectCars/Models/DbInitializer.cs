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
                    new Car { Make = "Porsche", Model = "Panamera 4S", YearOfProduction = 2019, Mileage = "3 km", Engine = "2 900 cm3", Fuel = "benzyna", HorsePower = "440 KM", Description = "Sportowa limuzyna od Porsche", Price = 600000M, MiniPhotoUrl = "/images/panamera4s_1.jpg", PhotoUrl1 = "/images/panamera4s_1.jpg", PhotoUrl2 = "/images/panamera4s_2.jpg", PhotoUrl3 = "/images/panamera4s_3.jpg", PhotoUrl4 = "/images/panamera4s_4.jpg" },
                    new Car { Make = "Mercedes-Benz", Model = "CLA", YearOfProduction = 2019, Mileage = "6 km", Engine = "2 000 cm3", Fuel = "benzyna", HorsePower = "398 KM", Description = "Nowy baby - benz jeszcze nigdy nie był tak dobry.", Price = 200000M, MiniPhotoUrl = "/images/cla_1.jpg", PhotoUrl1 = "/images/cla_1.jpg", PhotoUrl2 = "/images/cla_2.jpg", PhotoUrl3 = "/images/cla_3.jpg", PhotoUrl4 = "/images/cla_4.jpg" },
                    new Car { Make = "BMW", Model = "8 Series", YearOfProduction = 2019, Mileage = "8 km", Engine = "4 400 cm3", Fuel = "benzyna", HorsePower = "540 KM", Description = "Najnowsza 8 seria BMW.", Price = 700000M, MiniPhotoUrl = "/images/8_1.jpg", PhotoUrl1 = "/images/8_1.jpg", PhotoUrl2 = "/images/8_2.jpg", PhotoUrl3 = "/images/8_3.jpg", PhotoUrl4 = "/images/8_4.jpg" },
                    new Car { Make = "Mercedes-Benz", Model = "G Class", YearOfProduction = 2019, Mileage = "8 km", Engine = "4 000 cm3", Fuel = "benzyna", HorsePower = "420 KM", Description = "Samochód terenowy z prawdziwego zdarzenia.", Price = 600000M, MiniPhotoUrl = "/images/g_1.jpg", PhotoUrl1 = "/images/g_1.jpg", PhotoUrl2 = "/images/g_1.2pg", PhotoUrl3 = "/images/g_3.jpg", PhotoUrl4 = "/images/g_4.jpg" },
                    new Car { Make = "Audi", Model = "RS3 Limousine", YearOfProduction = 2019, Mileage = "4 km", Engine = "2 500 cm3", Fuel = "benzyna", HorsePower = "400 KM", Description = "400-konne RS 3 to najbardziej napakowany sportowy kompakt.", Price = 280000M, MiniPhotoUrl = "/images/rs3l_1.jpg", PhotoUrl1 = "/images/rs3l_1.jpg", PhotoUrl2 = "/images/rs3l_2.jpg", PhotoUrl3 = "/images/rs3l_3.jpg", PhotoUrl4 = "/images/rs3l_4.jpg" },
                    new Car { Make = "BMW", Model = "M4 Coupé", YearOfProduction = 2019, Mileage = "2 km", Engine = "3 000 cm3", Fuel = "benzyna", HorsePower = "425 KM", Description = "Jeżeli cenisz sobie szybkość i elegancje to jest to auto wprost dla ciebie.", Price = 300000M, MiniPhotoUrl = "/images/4_1.jpg", PhotoUrl1 = "/images/4_1.jpg", PhotoUrl2 = "/images/4_2.jpg", PhotoUrl3 = "/images/4_3.jpg", PhotoUrl4 = "/images/4_4.jpg" },
                    new Car { Make = "Porsche", Model = "718 Cayman S", YearOfProduction = 2019, Mileage = "1 km", Engine = "2 5000 cm3", Fuel = "benzyna", HorsePower = "350 KM", Description = "Flagowy model Porsche", Price = 380000M, MiniPhotoUrl = "/images/718_1.jpg", PhotoUrl1 = "/images/718_1.jpg", PhotoUrl2 = "/images/718_2.jpg", PhotoUrl3 = "/images/718_3.jpg", PhotoUrl4 = "/images/718_4.jpg" },
                    new Car { Make = "Mercedes-Benz", Model = "GT Coupé", YearOfProduction = 2019, Mileage = "13 km", Engine = "3 000 cm3", Fuel = "benzyna", HorsePower = "480 KM", Description = "Najbardziej sportowy Mercedes jaki powstał.", Price = 800000M, MiniPhotoUrl = "/images/gt_1.jpg", PhotoUrl1 = "/images/gt_1.jpg", PhotoUrl2 = "/images/gt_2.jpg", PhotoUrl3 = "/images/gt_3.jpg", PhotoUrl4 = "/images/gt_4.jpg" },
                    new Car { Make = "BMW", Model = "X6M", YearOfProduction = 2019, Mileage = "2 km", Engine = "4 400 cm3", Fuel = "benzyna", HorsePower = "555 KM", Description = "Prawdziwa 4 litrowa bestia dla fanów mocnych wrażeń.", Price = 550000M, MiniPhotoUrl = "/images/x6m_1.jpg", PhotoUrl1 = "/images/x6m_1.jpg", PhotoUrl2 = "/images/x6m_2.jpg", PhotoUrl3 = "/images/x6m_3.jpg", PhotoUrl4 = "/images/x6m_4.jpg" },
                    new Car { Make = "Porsche", Model = "Carrera 911 4GTS", YearOfProduction = 2019, Mileage = "10 km", Engine = "3 000 cm3", Fuel = "benzyna", HorsePower = "450 KM", Description = "Po prostu Porsche.", Price = 650000M, MiniPhotoUrl = "/images/911_1.jpg", PhotoUrl1 = "/images/911_1.jpg", PhotoUrl2 = "/images/911_2.jpg", PhotoUrl3 = "/images/911_3.jpg", PhotoUrl4 = "/images/911_4.jpg" },
                    new Car { Make = "Audi", Model = "S7 Sportback", YearOfProduction = 2019, Mileage = "3 km", Engine = "3 000 cm3", Fuel = "benzyna", HorsePower = "335 KM", Description = "Luksusowa i sportowa limuzyna.", Price = 350000M, MiniPhotoUrl = "/images/s7_1.jpg", PhotoUrl1 = "/images/s7_1.jpg", PhotoUrl2 = "/images/s7_2.jpg", PhotoUrl3 = "/images/s7_3.jpg", PhotoUrl4 = "/images/s7_4.jpg" }


                    );
            }

            context.SaveChanges();
        }
    }
}
