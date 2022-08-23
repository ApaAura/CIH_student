using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Triad
    {
        public int L1 { get; set; }
        public int L2 { get; set; }
        public int L3 { get; set; }
    }
    public class Triunghi : Triad
    {
        public void Citire()
        {
            Console.WriteLine("Introduceti datele : ");
            Console.Write("L1 = ");
            L1 = int.Parse(Console.ReadLine());
            Console.Write("L2 = ");
            L2 = int.Parse(Console.ReadLine());
            Console.Write("L3 = ");
            L3 = int.Parse(Console.ReadLine());
        }
        public bool Verifica()
        {
            bool Flag = false;
            if ((L1 + L2 > L3) & (L1 + L3 > L2) & (L2 + L3 > L1))
            {
                return Flag=true;
            }
            return Flag=false;
        }
        public int Perimetru() => L1 + L2 + L3;
        public double Semiperimetru() => Perimetru() / 2;
        public double Aria() =>Math.Sqrt(Semiperimetru()*(Semiperimetru()-L1)*(Semiperimetru()-L2)*(Semiperimetru()-L3));
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine("Datele trunghiului :");
            Console.WriteLine($"Latura 1 = {L1} cm\nLatura 2 = {L2} cm\nLatura 3 = {L3} cm");
            if (Verifica()==false)
            {
                Console.WriteLine("Laturile nu pot forma un triunghi !");
            }
            else
            {
                Console.WriteLine($"Perimetru = {Perimetru()} cm");
                Console.WriteLine($"Aria = {Aria():f4} cm");
            }
        }
    }
}
