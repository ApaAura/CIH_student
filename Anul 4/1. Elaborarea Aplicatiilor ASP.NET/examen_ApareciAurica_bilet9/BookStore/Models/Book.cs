using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public Guid ID { get; set; }
        [DisplayName("Titlu:")]
        [Required(ErrorMessage = "Campul 'Titlu' este obligatoriu!")]
        public string? Title { get; set; }

        [DisplayName("Autor:")]
        [Required(ErrorMessage = "Campul 'Autor' este obligatoriu!")]
        public string? Author { get; set; }

        [DisplayName("Editor:")]
        [Required(ErrorMessage = "Campul 'Editor' este obligatoriu!")]
        public string? Editor { get; set; }

        [DisplayName("Pret:")]
        [Required(ErrorMessage = "Campul 'Pret' este obligatoriu!")]
        public float Price { get; set; }
    }
}
