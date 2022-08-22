using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Automobil
    {
        public static int NrTotalAutomobile { get; private set; }

        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnulProducerii { get; set; }

        public Automobil(string marca, string model, int anulProducerii)
        {
            Marca = marca;
            Model = model;
            AnulProducerii = anulProducerii;

            NrTotalAutomobile++;
        }
    }
}
