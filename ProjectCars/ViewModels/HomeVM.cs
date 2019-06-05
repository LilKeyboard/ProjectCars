using ProjectCars.Models;
using System.Collections.Generic;

namespace ProjectCars.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Car> Cars { get; set; }
    }
}
