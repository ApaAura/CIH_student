using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Trapez : Figure
    {
        
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Trapez(double a, double b, double c)
        {
            A = a;//baza mica
            B = b;//baza mare
            C = c;//H
        }
        public override double Border()
        {
            double Llat = Math.Sqrt(Math.Pow((B - A), 2) + Math.Pow(A, 2));
            return A+B+C+Llat;
        }

        public override bool Exists()
        {
            if (A!=0 && B!=0 && C!=0)
            {
                return true;
            }
            return false;
        }

        public override double Square()
        {
            return (A + B) / 2 * C;
        }

        public override string Str()
        {
            return $" Trapez cu : \nBaza mica : {A}\nBaza mare : {B}\nInaltimea : {C}";
        }
        public void Afisare()
        {
            if (Exists() == true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(Str());
                Console.WriteLine($"Lungimea hotarului : {Border():f3} cm");
                Console.WriteLine($"Aria : {Square():f3} cm^2");
            }
            else
            {
                Console.WriteLine("Nu se poate forma o figura !");
            }
        }
    }
}
