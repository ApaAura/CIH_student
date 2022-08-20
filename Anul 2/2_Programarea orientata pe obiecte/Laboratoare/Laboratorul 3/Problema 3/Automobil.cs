using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    public class Automobil
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int Pret { get; set; }
    }
    public class DealerAuto
    {
        public string Adresa { get; set; }
        List<Automobil> Automobile = new List<Automobil>();
        public void Citire()
        {
            Console.WriteLine("Introduceti datele despre dealer-ul auto : ");
            Console.Write($"Adresa :");
            Adresa =Console.ReadLine();
            Console.Write("Introduceti numarul de automobile :");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Automobilul {i+1}");
                Automobil automobil1=new Automobil();
                Console.Write("Marca : ");
                automobil1.Marca = Console.ReadLine();
                Console.Write("Model : ");
                automobil1.Model = Console.ReadLine();
                Console.Write("Pret : ");
                automobil1.Pret= int.Parse(Console.ReadLine());
                Automobile.Add(automobil1);
                Console.WriteLine("Datele au fost inscrise cu succes !");
            }
        }
        public void Afisare()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Datele despre dealer-ul auto: ");
            Console.WriteLine($"Adresa : {Adresa}");
            Console.WriteLine($"Automobile detinute : ");
            Automobile.ForEach(q =>
            {
                Console.WriteLine($"Marca model : {q.Marca} {q.Model}");
                Console.WriteLine($"Pret : {q.Pret}");
            });
        }
    }
}
