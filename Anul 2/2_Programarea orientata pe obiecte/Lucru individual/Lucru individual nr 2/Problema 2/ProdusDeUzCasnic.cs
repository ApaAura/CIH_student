using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class ProdusDeUzCasnic : Produs
    {
        public int luniGarantie { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele produsului de uz casnic : ");
            base.Citire();
            Console.Write("Luni garantie : ");
            luniGarantie=int.Parse(Console.ReadLine());
        }
        public void anuleazaGarantia()
        {
            bool AreGarantie = true;
            int LuniDeLaCumparare = 0;
            if (LuniDeLaCumparare>luniGarantie)
            {
                AreGarantie=false;
            }
        }
        public void afisareInformatii()
        {
            Console.WriteLine("Datele produsului de uz casnic : ");
            base.afisareInformatii();
            Console.WriteLine($"Luni garantie : {luniGarantie}");
        }
    }
}
