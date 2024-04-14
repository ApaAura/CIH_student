using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarStore.Models
{
    public class Producer
    {
        public Producer()
        {
            ProdID = Guid.NewGuid();
            Cars = new List<Car>();
        }
        [Key]
        public Guid ProdID { get; set; }

        [DisplayName("Denumire:")]
        [Required(ErrorMessage = "Campul 'Denumire' este obligatoriu!")]
        public string? Denumire { get; set; }

        [DisplayName("Adresa prducator:")]
        [Required(ErrorMessage = "Campul 'Adresa producator' este obligatoriu!")]
        public string? Adresa { get; set; }
        //entityframework mapping
        public ICollection<Car>? Cars { get; set; }
    }
}
