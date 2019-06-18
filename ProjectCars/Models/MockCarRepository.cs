//using System.Collections.Generic;
//using System.Linq;

//namespace ProjectCars.Models
//{
//    public class MockCarRepository : ICarRepository
//    {
//        private List<Car> cars;

//        public MockCarRepository()
//        {
//            if (cars == null)
//            {
//                LoadCars();
//            }
//        }

//        private void LoadCars()
//        {
//            cars = new List<Car>
//            {
//                new Car { Id = 1, Make = "Audi", Model = "RS3 Sportback", YearOfProduction = 2019, Mileage = " 10 km", Engine = "2 500 cm3", Fuel = "benzyna", HorsePower = "395 KM", Description = "Jeden z najszybszych hot-hatchów na świecie. ", Price = 200000M, MiniPhotoUrl = "/images/rs3_1.jpg", PhotoUrl1 = "/images/rs3_1.jpg", PhotoUrl2 = "/images/rs3_2.jpg", PhotoUrl3 = "/images/rs3_3.jpg", PhotoUrl4 = "/images/rs3_4.jpg" },
//                new Car { Id = 2, Make = "Audi", Model = "RS3 Sportback", YearOfProduction = 2019, Mileage = " 10 km", Engine = "2 500 cm3", Fuel = "benzyna", HorsePower = "395 KM", Description = "Jeden z najszybszych hot-hatchów na świecie. ", Price = 200000M, MiniPhotoUrl = "/images/rs3_1.jpg", PhotoUrl1 = "/images/rs3_1.jpg", PhotoUrl2 = "/images/rs3_2.jpg", PhotoUrl3 = "/images/rs3_3.jpg", PhotoUrl4 = "/images/rs3_4.jpg" }

//            };
//        }

//        public IEnumerable<Car> GetAllCars()
//        {
//            return cars;
//        }

//        public Car GetCarById(int CarId)
//        {
//            return cars.FirstOrDefault(s => s.Id == CarId);
//        }

//        public IEnumerable<Car> GetCarsByMake(string Make)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void AddCar(Car car)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void EditCar(Car car)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void RemoveCar(Car car)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
