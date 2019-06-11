using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCars.Models
{
    public class Opinion
    {
        [BindNever] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Login jest za dlugi")]
        [StringLength(100, ErrorMessage = "Login jest za dlugi")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [StringLength(100, ErrorMessage = "Email jest za dlugi")]
        [DataType(DataType.EmailAddress)]   //Spodziewamy sie podania maila stad to
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "To nie jest prawidlowy email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wiadomosc jest wymagana")]
        [StringLength(5000, ErrorMessage = "Wiadomosc jest za dluga")]
        public string Message { get; set; }

        public bool WantReply { get; set; }
    }
}
