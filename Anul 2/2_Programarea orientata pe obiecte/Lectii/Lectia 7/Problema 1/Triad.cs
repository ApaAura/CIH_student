using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Triad
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public Triad()
        {
        }
        public Triad(int n1, int n2, int n3)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }
        public void Citire()
        {
            Console.WriteLine("Introduceti dimensiunile: ");
            Console.Write("Baza mare = ");
            N1=int.Parse(Console.ReadLine());
            Console.Write("Baza mica = ");
            N2 =int.Parse(Console.ReadLine());
            Console.Write("Inaltimea = ");
            N3 =int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Datele trapezului :");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Baza mare = {N1}\nBaza mica = {N2}\nInaltimea = {N3}");
        }
    }
}
