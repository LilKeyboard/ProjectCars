using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCars.Models
{
   //[Table("Cars")]
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int YearOfProduction { get; set; }

        [Required]
        public string Mileage { get; set; }

        [Required]
        public string Engine { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required]
        public string HorsePower { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0.01, 8000000, ErrorMessage = "Cena musi być wyższa niż 0.01 zł")]
        public decimal Price { get; set; }

        [Required]
        public string MiniPhotoUrl { get; set; }

        [Required]
        public string PhotoUrl1 { get; set; }

        public string PhotoUrl2 { get; set; }

        public string PhotoUrl3 { get; set; }

        public string PhotoUrl4 { get; set; }

    }
}
