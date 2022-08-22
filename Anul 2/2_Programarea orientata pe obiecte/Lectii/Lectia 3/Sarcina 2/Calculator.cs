using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarcina_2
{
    internal class Calculator
    {
        public class Processor
        {
            public string Model { get; set; }
            public int Frecventa { get; set; }
            public int NumarNuclee { get; set; }
        }
        public class PlacaVideo
        {
            public string Model { get; set; }
            public int VRAM { get; set; }
        }
        public string Marca { get; set; }
        public string Model { get; set; }    
        public string Producator { get; set;}
        public Processor processor { get; set; }
        public PlacaVideo placaVideo { get; set; }
        public int Pret { get; set;}
        
        public void Citire()
        {
            Console.WriteLine("Introduceti datele despre calculator: ");
            Console.Write("Marca : ");
            Marca = Console.ReadLine();

            Console.Write("Model : ");
            Model = Console.ReadLine();

            Console.Write("Producator : ");
            Producator = Console.ReadLine();

            Console.Write("Model procesor : ");
            processor.Model = Console.ReadLine();

            Console.Write("Frecventa procesor : ");
            processor.Frecventa = int.Parse(Console.ReadLine());

            Console.Write("Numar nuclee procesor : ");
            processor.NumarNuclee = int.Parse(Console.ReadLine());

            Console.Write("Model placa video : ");
            placaVideo.Model = Console.ReadLine();

            Console.Write("VRAM placa video : ");
            placaVideo.VRAM = int.Parse(Console.ReadLine());

            Console.Write("Pret : ");
            Pret = int.Parse(Console.ReadLine());
        } 
        public void Afisare()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Caracteristicile calculatorului :");
            Console.WriteLine("___________________________________");
            Console.WriteLine($"Marca : {Marca}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Produator : {Producator}");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Caracteristicile procesorului :");
            Console.WriteLine("___________________________________");
            Console.WriteLine($"Model : {processor.Model}");
            Console.WriteLine($"Frecventa : {processor.Frecventa}");
            Console.WriteLine($"Numar nuclee : {processor.NumarNuclee}");
            Console.WriteLine("___________________________________");
            Console.WriteLine("Caracteristicile placii video : ");
            Console.WriteLine("___________________________________");
            Console.WriteLine($"Model : {placaVideo.Model}");
            Console.WriteLine($"VRAM : {placaVideo.VRAM}");
            Console.WriteLine("___________________________________");
            Console.WriteLine($"Pret: {Pret}");
        }
    }
}
