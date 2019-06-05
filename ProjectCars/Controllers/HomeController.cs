using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectCars.Models;

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
            ViewBag.title = "Przeglad Samochodow";

            var cars = _carRepository.GetAllCars().OrderBy(s => s.Make);

            return View(cars);
        }
    }
}