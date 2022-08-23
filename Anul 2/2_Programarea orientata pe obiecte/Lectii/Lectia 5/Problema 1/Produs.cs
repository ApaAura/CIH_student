using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    public class Produs
    {
        public int Pret { get; set; }
        public string Producator { get; set; }
        public string Distribuitor { get; set; }
        public void AfisareInformatii() { }
    }
    public class ProdusAlimentar : Produs
    {
        public int Valabilitate { get; set; }
        public void AfisareInformatii() { }
    }
    public class ProdusElectronic : Produs
    {
        public int luniGarantie { get; set; }
        public void AfisareInformatii() { }
        public void AnuleazaGarantia() { }
    }
}
