using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal interface IVehicul
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnulProducerii { get; set; }
        public void Porneste();
        public void Opreste();
        public void Deplaseaza();
    }
}
