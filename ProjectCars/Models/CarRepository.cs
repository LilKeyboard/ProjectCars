using System.Collections.Generic;
using System.Linq;
using Remotion.Linq.Clauses;

namespace ProjectCars.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _appDbContext.Cars;
        }

        public Car GetCarById(int Id)
        {
            return _appDbContext.Cars.FirstOrDefault(c => c.Id == Id);
        }

        public IEnumerable<Car> GetCarsByMake(string Make)
        {
            return _appDbContext.Cars.Where(c => c.Make.Contains(Make));
        }
    }
}
