using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace app.Models;

public class Student
{
    [DisplayName("Nume:")]
    [Required(ErrorMessage = "Campul 'Nume' este obligatoriu!")]
    public string? FirstName { get; set; }
    [DisplayName("Prenume:")]
    [Required(ErrorMessage = "Campul 'Prenume' este obligatoriu!")]
    public string? LastName { get; set; }
    [DisplayName("Email:")]
    [EmailAddress]
    [Required(ErrorMessage = "Campul 'Email' este obligatoriu!")]
    public string? Email { get; set; }
    [DisplayName("Numar de telefon:")]
    [Required(ErrorMessage = "Campul 'Numar de telefon' este obligatoriu!")]
    [Phone]
    public string? Phone { get; set; }
    [DisplayName("Domiciliu:")]
    [Required(ErrorMessage = "Campul 'Domiciliu' este obligatoriu!")]
    public string? Adress { get; set; }
    [DisplayName("IDNP:")]
    [MinLength(13, ErrorMessage ="Campul trebuie sa aiba 13 caractere")]
    [MaxLength(13, ErrorMessage = "Campul trebuie sa aiba 13 caractere")]
    [Required(ErrorMessage = "Campul 'IDNP' este obligatoriu!")]
    public string? IDNP { get; set; }
}
