﻿using System.Collections.Generic;

namespace ProjectCars.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int Id);
    }
}