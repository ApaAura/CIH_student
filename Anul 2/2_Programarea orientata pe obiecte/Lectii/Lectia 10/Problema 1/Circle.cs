using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Circle : Figure
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Border()
        {
            return 2*r*Math.PI;
        }
        public override bool Exists()
        {
            bool val = false;
            if (r>0)
            {
                val = true;
            }
            return val;
        }
        public override double Square()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        public override string Str()
        {
            return $"Cerc: cu raza {r}";
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
