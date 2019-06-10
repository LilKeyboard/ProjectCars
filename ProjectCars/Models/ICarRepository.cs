using System.Collections.Generic;

namespace ProjectCars.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int Id);
        IEnumerable<Car> GetCarsByMake(string Make);

        void AddCar(Car car);
        void EditCar(Car car);
        void RemoveCar(Car car);
    }
}
