using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Nume:")]
        [Required(ErrorMessage = "Campul 'Nume' este obligatoriu!")]
        public string? Nume { get; set; }
        [DisplayName("Prenume:")]
        [Required(ErrorMessage = "Campul 'Prenume' este obligatoriu!")]
        public string? Prenume { get; set; }
        [DisplayName("Grupa:")]
        [Required(ErrorMessage = "Campul 'Grupa' este obligatoriu!")]
        public string? Grupa { get; set; }
        [DisplayName("Nota medie:")]
        [Required(ErrorMessage = "Campul 'Nota medie' este obligatoriu!")]
        public double Nota { get; set; }
    }
}
