using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Triangle : Figure
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Border()
        {
            return a + b + c;
        }
        public override bool Exists()
        {
            bool val = false;
            if ((a <= b + c) || (b <= a + c) || (c <= b + c))
            {
                val = true;
            }
            return val;
        }
        public override double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        public override string Str()
        {
            return $"Triunghi: cu laturile {a}, {b}, si {c}";
        }
        public void Afisare()
        {
            if (Exists()==true)
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
