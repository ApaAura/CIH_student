using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
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
        [Required(ErrorMessage = "Campul 'Adresa' este obligatoriu!")]
        public string? Adresa { get; set; }
        [DisplayName("Email:")]
        [Required(ErrorMessage = "Campul 'Email' este obligatoriu!")]
        public string? Email { get; set; }
        [DisplayName("Data nasterii:")]
        [Required(ErrorMessage = "Campul 'Data nasterii' este obligatoriu!")]
        public DateTime? DataNasterii { get; set; } 
        [DisplayName("Sex:")]
        [Required(ErrorMessage = "Campul 'Sex' este obligatoriu!")]
        public string? Sex { get; set; }
        [DisplayName("Nota medie:")]
        [Required(ErrorMessage = "Campul 'Nota medie' este obligatoriu!")]
        [Range(1,10, ErrorMessage ="Nota trebuie sa fie cuprinsa intre 1 si 10!")]
        public double Media { get; set; }
    }
}
