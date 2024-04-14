using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace laborator_3._1.Models
{
    public class Paralelipiped
    {
        [DisplayName("A")]
        [Required(ErrorMessage = "Dimensiunea este obligatorie ")]
        [Range(0.00, 100.00, ErrorMessage = "Valoarea trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double a {  get; set; }

        [DisplayName("B")]
        [Required(ErrorMessage = "Dimensiunea este obligatorie ")]
        [Range(0.00, 100.00, ErrorMessage = "Valoarea trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double b { get; set; }

        [DisplayName("C")]
        [Required(ErrorMessage = "Dimensiunea este obligatorie ")]
        [Range(0.00, 100.00, ErrorMessage = "Valoarea trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double c { get; set; }

        public double Aria()
        {
            return 2*(a*b+a*c+b*c);
        }
        public double Volum()
        {
            return a*b*c;
        }
    }
}
