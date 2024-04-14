using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarStore.Models
{
    public class Car
    {
        public Car()
        {
            ID = Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; set; }
        [DisplayName("Model:")]
        [Required(ErrorMessage = "Campul 'Model' este obligatoriu!")]
        public string? Model { get; set; }

        [DisplayName("Pret:")]
        [Required(ErrorMessage = "Campul 'Pret' este obligatoriu!")]
        public float Price { get; set; }

        [DisplayName("Cpacitatea motorului:")]
        [Required(ErrorMessage = "Campul 'Capacitatea motorului' este obligatoriu!")]
        public float CapacitateaMotorului { get; set; }

        [DisplayName("Tipul combustibilului:")]
        [Required(ErrorMessage = "Campul 'Tipul combustibilului' este obligatoriu!")]
        public string? TipulCombustibilului { get; set; }

        [DisplayName("Transmisie:")]
        [Required(ErrorMessage = "Campul 'Transmisie' este obligatoriu!")]
        public string? Transmisie { get; set; }

        [DisplayName("Tip tractiune:")]
        [Required(ErrorMessage = "Campul 'Tip tractiune' este obligatoriu!")]
        public string? TipTractiune { get; set; }

        [DisplayName("Numarul de usi:")]
        [Required(ErrorMessage = "Campul 'Numarul de usi' este obligatoriu!")]
        public int NumarUsi { get; set; }

        [DisplayName("Numarul de locuri:")]
        [Required(ErrorMessage = "Campul 'Numarul de locuri' este obligatoriu!")]
        public int NumarLocuri { get; set; }

        [NotMapped]
        [DisplayName("Incarca imaginea:")]
        [Required(ErrorMessage = "You must upload a image of the car")]
        public IFormFile? FormFile { get; set; }

        public Guid ProdID { get; set; }
        public Producer? Producer { get; set; }
        public string? Path { get; set; } = "NotSet";

    }
}
