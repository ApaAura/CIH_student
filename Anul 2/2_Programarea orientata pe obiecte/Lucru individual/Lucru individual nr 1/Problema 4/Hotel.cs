using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Hotel
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public int NrStele { get; set; }
        public int NrCamere { get; set; }
        public double PretMin { get; set; }
        public double PretMax { get; set; }
        public Hotel()
        {
        }
        public Hotel(string nume, string adresa, int nrStele, int nrCamere, double pretMin, double pretMax)
        {
            Nume = nume;
            Adresa = adresa;
            NrStele = nrStele;
            NrCamere = nrCamere;
            PretMin = pretMin;
            PretMax = pretMax;
        }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele despre hotel : ");
            Console.WriteLine("------------------------------------");
            Console.Write("Nume : ");
            Nume=Console.ReadLine();
            Console.Write("Adresa : ");
            Adresa=Console.ReadLine();
            Console.Write("Numarul de stele : ");
            NrStele=int.Parse(Console.ReadLine());
            Console.Write("Numarul de camere : ");
            NrCamere=int.Parse(Console.ReadLine());
            Console.Write("Pretul maxim : ");
            PretMax=double.Parse(Console.ReadLine());
            Console.Write("Pretul minim : ");
            PretMin=double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
        }
        public void Afisare()
        {
            Console.WriteLine($"Nume : {Nume}");
            Console.WriteLine($"Adresa : {Adresa}");
            Console.WriteLine($"Numarul de stele : {NrStele}");
            Console.WriteLine($"Numarul de camere : {NrCamere}");
            Console.WriteLine($"Pret maxim : {PretMax}");
            Console.WriteLine($"Pret minim : {PretMin}");
        }
    }
}
