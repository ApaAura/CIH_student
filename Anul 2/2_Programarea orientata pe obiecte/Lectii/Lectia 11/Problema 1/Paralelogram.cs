using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Paralelogram : Figure
    {
        public double lungimea { get; set; }
        public double latimea { get; }
        public double inaltimea { get; set; }
        public Paralelogram(double lungimea, double latimea, double inaltimea)
        {
            this.lungimea = lungimea;
            this.latimea = latimea;
            this.inaltimea = inaltimea;
        }
        public override double Square()
        {
            return lungimea*inaltimea;
        }
        public override double Border()
        {
            return lungimea + latimea + lungimea + latimea;
        }
        public override bool Exists()
        {
            if (lungimea != 0 && latimea != 0 && inaltimea != 0)
            {
                return true;
            }
            return false;
        }
        public override string Str()
        {
            return $" Trapez cu : \nLungimea : {lungimea}\nLatura laterala : {latimea}\nInaltimea : {inaltimea}";
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
