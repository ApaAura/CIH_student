using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Carte
    {
        public string Autor { get; set; }
        public string Titlu { get; set; }
        public Carte()
        {
        }
        public Carte(string autor, string titlu)
        {
            Autor = autor;
            Titlu = titlu;
        }
        public void Citire()
        {
            Console.Write("Autor : ");
            Autor = Console.ReadLine();
            Console.Write("Titlu : ");
            Titlu = Console.ReadLine();
        }
        public void Afisare()
        {
            Console.WriteLine($"Autor Titlu : {Autor} {Titlu}");
        }
    }
    public class Biblioteca
    {
        public string Adresa;
        List<Carte> carti = new List<Carte>();
        public void Citire()
        {
            Console.WriteLine("Introduceti datele despre biblioteca :");
            Console.Write("Adresa : ");
            Adresa=Console.ReadLine();
            Console.Write("Introduceti numarul de carti : ");
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Carte carte = new Carte();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Datele despre carte {i+1}");
                carte.Citire();
                carti.Add(carte);
            }
        }
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Datele bibliotecii : ");
            Console.WriteLine($"Adresa : {Adresa}");
            Console.WriteLine("Carti detinute : ");
            foreach (Carte item in carti)
            {
                item.Afisare();
            }
        }
    }
}
