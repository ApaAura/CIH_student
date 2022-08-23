using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Putere
    {
        public int Exponent { get; set; }
        public int Baza { get; set; }
        public Putere(int exponent, int baza)
        {
            Exponent = exponent;
            Baza = baza;
        }
        public Putere()
        {
        }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele :");
            Console.Write("Baza : ");
            Baza=int.Parse(Console.ReadLine());
            Console.Write("Exponent : ");
            Exponent=int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public Putere(Putere Pow)
        {
            Exponent = Pow.Exponent;
            Baza=Pow.Baza;
        }
        public double Power()=>Math.Pow(Baza,Exponent);
        public void Afisare()
        {
            Console.WriteLine($"{Baza}^{Exponent}={Power()}");
        }
    }
}
