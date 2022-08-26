using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Problema_2
{
    internal class Automobil : IVehicul, ISistemAudio, INavigatie
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnulProducerii { get; set; }
        public string ModelGPS { get; set; }
        public string ModelSistemAudio { get; set; }
        public Automobil(string marca, string model, int anulProducerii, string modelGPS, string modelSistemAudio)
        {
            Marca = marca;
            Model = model;
            AnulProducerii = anulProducerii;
            ModelGPS = modelGPS;
            ModelSistemAudio = modelSistemAudio;
        }
        public void Canta()
        {
            Console.WriteLine("gucci gang gucci gang ");
        }
        public void Deplaseaza()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Automobilul de deplaseaza...");
                Thread.Sleep(500);
            }
        }
        public void Localizeaza()
        {
            int x = 100;
            int y = 200;
            Console.WriteLine($"({x},{y})");
        }
        public void Opreste()
        {
            Console.WriteLine("Automobilul a fost oprit");
        }
        public void Porneste()
        {
            Console.WriteLine("Automobilul a fost pornit");
        }
    }
}
