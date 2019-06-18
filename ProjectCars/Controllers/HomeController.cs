using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectCars.Models;
using ProjectCars.ViewModels;

namespace ProjectCars.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var cars = _carRepository.GetAllCars().OrderBy(s => s.Make);

            var homeVM = new HomeVM()
            {
                Title = "Przeglad Samochodow",
                Cars = cars.ToList()
            };

            return View(homeVM);
        }

        public IActionResult Contact()
        {
            return View("Contact");
        }

        public IActionResult AboutUs()
        {
            return View("AboutUs");
        }

        public IActionResult OnlyOneMake(string Make)
        {
            return View(_carRepository.GetCarsByMake(Make));
        }

        public IActionResult Details(int Id)
        {
            var car = _carRepository.GetCarById(Id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
    }
}