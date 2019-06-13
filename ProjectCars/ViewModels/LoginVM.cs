using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCars.ViewModels
{
    public class LoginVM
    {
        [Required]
        [DisplayName("Nazwa Użytkownika")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Hasło")]
        public string Password { get; set; }

    }
}
