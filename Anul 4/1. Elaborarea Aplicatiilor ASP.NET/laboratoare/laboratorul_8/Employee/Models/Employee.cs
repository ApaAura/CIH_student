using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Nume:")]
        [Required(ErrorMessage = "Campul 'Nume' este obligatoriu!")]
        public string? Nume { get; set; }
        [DisplayName("Prenume:")]
        [Required(ErrorMessage = "Campul 'Prenume' este obligatoriu!")]
        public string? Prenume { get; set; }
        [DisplayName("Postul ocupat:")]
        [Required(ErrorMessage = "Campul 'Post' este obligatoriu!")]
        public string? Post { get; set; }
        [DisplayName("Salariul:")]
        [Required(ErrorMessage = "Campul 'Salariu' este obligatoriu!")]
        public double Salariu { get; set; }
    }
}
