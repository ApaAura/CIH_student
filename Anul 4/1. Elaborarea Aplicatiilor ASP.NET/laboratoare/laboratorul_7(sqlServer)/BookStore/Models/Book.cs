using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public Guid ID { get; set; }
        [DisplayName("Titlu:")]
        [Required(ErrorMessage = "Campul 'Titlu' este obligatoriu!")]
        public string? Title { get; set; }
        [DisplayName("Descriere:")]
        [Required(ErrorMessage = "Campul 'Descriere' este obligatoriu!")]
        public string? Description { get; set; }
        [DisplayName("Autor:")]
        [Required(ErrorMessage = "Campul 'Autor' este obligatoriu!")]
        public string? Author { get; set; }
        [DisplayName("Editura:")]
        [Required(ErrorMessage = "Campul 'Editura' este obligatoriu!")]
        public string? Editura { get; set; }
        [DisplayName("Pret:")]
        [Required(ErrorMessage = "Campul 'Pret' este obligatoriu!")]
        public float Price { get; set; }
        public string? Path { get; set; }
        [NotMapped]
        [DisplayName("Book cover:")]
        [Required(ErrorMessage ="You must upload a image of the book cover")]
        public IFormFile? FormFile { get; set; }
    }
}
