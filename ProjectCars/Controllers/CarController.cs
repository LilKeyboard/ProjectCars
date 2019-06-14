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

        public IActionResult Index()
        {
            return View(_carRepository.GetAllCars());
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.AddCar(car);
                return RedirectToAction("Index");
            }

            return View(car);
        }

        public IActionResult Edit(int id)
        {
            var car = _carRepository.GetCarById(id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
    }
}