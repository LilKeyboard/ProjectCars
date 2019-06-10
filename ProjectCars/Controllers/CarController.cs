using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectCars.Models;

namespace ProjectCars.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult OnlyOneMake(string Make)
        {
            return View(_carRepository.GetCarsByMake(Make));
        }

    }
}