using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectCars.Models;

namespace ProjectCars.Controllers
{
    [Authorize]
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository _opinionRepository;

        public OpinionController(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Index(Opinion opinion)      
        {
            if (ModelState.IsValid)
            {
                _opinionRepository.AddOpinion(opinion);
                return RedirectToAction("OpinionSent");
            }

            return (View(opinion));  //If smth is wrong in form
        }

        public IActionResult OpinionSent()
        {
            return View();
        }
    }
}