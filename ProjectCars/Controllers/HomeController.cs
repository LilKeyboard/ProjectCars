﻿using System;
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
    }
}