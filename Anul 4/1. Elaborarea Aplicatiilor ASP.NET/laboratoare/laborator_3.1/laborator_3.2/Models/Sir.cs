using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace laborator_3._2.Models
{
    public class Sir
    {
        [DisplayName("Introduceti sirul de caractere: ")]
        [Required(ErrorMessage = "Campul este obligatoriu ")]
        public string sirCaractere { get; set; }
        public int nrVocale()
        {
            return sirCaractere.ToLower().Count(c => "aeiou".Contains(c)); ;
        }
        public int nrConsone()
        {
            return sirCaractere.ToLower().Count(c => "bcdfghjklmnpqrstvwxyz".Contains(c)); ;
        }
        public int nrCifre()
        {
            return sirCaractere.ToLower().Count(c => "0123456789".Contains(c)); ;
        }
        public int nrSemneSpeciale()
        {
            return sirCaractere.Count(c => !char.IsLetterOrDigit(c)); ;
        }

    }
}
