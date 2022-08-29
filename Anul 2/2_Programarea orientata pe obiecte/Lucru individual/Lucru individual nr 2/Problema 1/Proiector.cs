using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Proiector : Dispozitiv
    {
        public int zileDurataDeViataALampii { get; set; }
        public void CitireInformatii()
        {
            Console.WriteLine("Introduceti datele proiectorului :");
            base.CitireInformatii();
            Console.Write("Zile durata de viata a lampii : ");
            zileDurataDeViataALampii=int.Parse(Console.ReadLine());
        }
        public void AfisareInformatii()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Datele proiectorului : ");
            Console.WriteLine("-----------------------------");
            base.AfisareInformatii();
            Console.WriteLine($"Zile durata de viata a lampii : {zileDurataDeViataALampii}");
        }
    }
}
