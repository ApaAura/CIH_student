using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
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
            Console.Write("Baza = ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Latura = ");
            N2 = int.Parse(Console.ReadLine());
            Console.Write("Inaltimea = ");
            N3= int.Parse(Console.ReadLine());  
        }
        public void Afisare()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Datele paralelogramului :");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Baza = {N1}\nLatura = {N2}\nInaltimea = {N3}");
        }
    }
}
