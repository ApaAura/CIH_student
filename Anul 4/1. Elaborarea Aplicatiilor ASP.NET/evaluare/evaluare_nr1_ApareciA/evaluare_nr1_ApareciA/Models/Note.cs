using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace evaluare_nr1_ApareciA.Models
{
    public class Note
    {
        [DisplayName("Limba de instruire")]
        [Required(ErrorMessage ="Nota la limba de instruire este obligatorie")]
        [Range(5.00, 10.00, ErrorMessage = "Nota la {0} trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double LimbaInstruire { get; set; }

        [DisplayName("Limba straina")]
        [Required(ErrorMessage = "Nota la limba straina este obligatorie")]
        [Range(5.00, 10.00, ErrorMessage = "Nota la {0} trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double LimbaStraina { get; set; }

        [DisplayName("Matematica")]
        [Required(ErrorMessage = "Nota la matematica este obligatorie")]
        [Range(5.00, 10.00, ErrorMessage = "Nota la {0} trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double Matematica { get; set; }

        [DisplayName("Nota de profil")]
        [Required(ErrorMessage = "Nota la disciplina de profil este obligatorie")]
        [Range(5.00, 10.00, ErrorMessage = "Nota la {0} trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double Profil { get; set; }

        [DisplayName("MNEA (ex:9.33 nu 9,33)")]
        [Required(ErrorMessage = "Nota la MNEA este obligatorie")]
        [Range(5.00, 10.00, ErrorMessage = "Nota la {0} trebuie sa fie coprinsa in intervalul {1} - {2}")]
        public double MNEA { get; set; }


        public double MC()
        {
            double MNDP = (LimbaInstruire + LimbaStraina + Matematica + Profil) / 4;
            double MC = 0.6 * MNDP + 0.4 * MNEA;
            return MC;
        }
    }
}
