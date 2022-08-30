using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Square : ISolution
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public Square(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool Existence()
        {
            double dis = Math.Pow(b, 2) - 4 * a * c;
            if (dis < 0)
            {
                return false;
            }
            else return true;
        }
        public void Afisare()
        {
            double dis = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Ecuatia patrata !");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"{a}X^2+{b}X+{c}=0");
            if (Existence()==true)
            {
                if (dis == 0)
                {
                    Console.WriteLine($"X = {-b / 2 * a}");
                }
                else
                {
                    Console.WriteLine($"X1 = {-b - Math.Sqrt(dis) / 2 * a:f2}");
                    Console.WriteLine($"X2 = {-b + Math.Sqrt(dis) / 2 * a:f2}");
                }
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii !");
            }
            
            Console.WriteLine("--------------------------");
        }
    }
}
