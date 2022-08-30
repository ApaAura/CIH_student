using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class DispozitivElectronic
    {
        public int Pret { get; set; }
        public string Model { get; set; }
        public string Producator { get; set; }
        public DateTime DataFabricarii { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele calculatorului : ");
            Console.Write("Pret : ");
            Pret = int.Parse(Console.ReadLine());
            Console.Write("Model : ");
            Model = Console.ReadLine();
            Console.Write("Producator : ");
            Producator = Console.ReadLine();
            Console.Write("Data fabricarii : ");
            DataFabricarii = DateTime.Parse(Console.ReadLine());
        }
        public int Zile()=> DateTime.Now.Day-DataFabricarii.Day;
        public void Info()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Datele calculatorului : ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Pret : {Pret}\nModel : {Model}\nProducator : {Producator}");
        }
    }
}
