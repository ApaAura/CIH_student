using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Proiector : Produs
    {
        public int DurataDeViataALampii { get; set; }
        public double DistantaMaximaDeRedare { get; set; }
        public override void Citire()
        {
            Console.WriteLine("Introduceti datele proiectorului : ");
            base.Citire();
            Console.Write("Durata de viata a lampii : ");
            DurataDeViataALampii=int.Parse(Console.ReadLine());
            Console.Write("Distanta maxima de redare : ");
            DistantaMaximaDeRedare=double.Parse(Console.ReadLine());
        }
        public override void Info()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Datele despre proiector : ");
            Console.WriteLine("-------------------------------");
            base.Info();
            Console.WriteLine($"Durata de viata a lampii : {DurataDeViataALampii} ");
            Console.WriteLine($"Distanta maxima de redare : {DistantaMaximaDeRedare}");
        }
    }
}
