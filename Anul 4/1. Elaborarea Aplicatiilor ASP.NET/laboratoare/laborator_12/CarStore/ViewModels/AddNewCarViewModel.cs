using CarStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace CarStore.ViewModels
{
    public class AddNewCarViewModel
    {
        [DisplayName("Producator")]
        public IEnumerable<Producer> Producers { get; set; }
        public IEnumerable<SelectListItem> Transmision { get; set; }
        public IEnumerable<SelectListItem> Traction { get; set; }
        public Car Car { get; set; }

        public AddNewCarViewModel()
        {
            Car = new Car();
            Producers = new List<Producer>();
            Transmision = new List<SelectListItem>
            {
                new SelectListItem { Value = "manual", Text = "Manuala" },
                new SelectListItem { Value = "automat", Text = "Automata" },
            };
            Traction = new List<SelectListItem>
            {
                new SelectListItem { Value = "fata", Text = "Tractiune fata" },
                new SelectListItem { Value = "spate", Text = "Tractiune spate" },
                new SelectListItem { Value = "integrala", Text = "Tractiune integrala" },
            };
        }
    }
}
