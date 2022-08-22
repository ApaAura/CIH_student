using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Telefon
    {
        public class MicroProcessor
        {
            public string Model { get; set; }
        }
        public class Camera
        {
            public string Rezolutie { get; set; }
            public bool WideCameraSupport { get; set; }
        }
        public string Model { get; set; }
        public double Pret { get; set; }
        public MicroProcessor microProcessor { get; set; }
        public Camera camera { get; set; }

        public Telefon()
        {
            microProcessor = new MicroProcessor();
            camera = new Camera();
        }
        public void Citire()
        {
            Console.Write("Mode: ");
            Model = Console.ReadLine();

            Console.Write("Pret: ");
            Pret = Double.Parse(Console.ReadLine());

            Console.Write("Microprocessor: Model: ");
            microProcessor.Model = Console.ReadLine();

            Console.Write("Camera: Rezolutie: ");
            camera.Rezolutie = Console.ReadLine();

            Console.Write("Camera: WideCameraSupport? (Y/N): ");
            camera.WideCameraSupport = (Console.ReadLine().ToUpper() == "Y") ? true : false;
        }
        public void Afisare()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Pret: " + Pret);
            Console.WriteLine("Model microprocessor: " + microProcessor.Model);
            Console.WriteLine("Rezolutie camera: " + camera.Rezolutie);
            Console.WriteLine("Wide support camera: " + camera.WideCameraSupport.ToString());
        }
    }
}
