using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Dispozitiv
    {
        public string Model { get; set; }
        public double Pret { get; set; }
        public int anulFabricarii { get; set; }
        public void CitireInformatii()
        {
            Console.Write("Model : ");
            Model=Console.ReadLine();
            Console.Write("Pret : ");
            Pret=double.Parse(Console.ReadLine());
            Console.Write("Anul fabricarii : ");
            anulFabricarii=int.Parse(Console.ReadLine());
        }
        public void AfisareInformatii()
        {
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Pret : {Pret}");
            Console.WriteLine($"Anul fabricarii : {anulFabricarii}");
        }
    }
}
