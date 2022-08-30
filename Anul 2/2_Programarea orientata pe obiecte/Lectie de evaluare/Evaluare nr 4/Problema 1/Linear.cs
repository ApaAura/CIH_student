using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Linear: ISolution
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public Linear(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public bool Existence()
        {
            if (a == 0)
            {
                return false;
            }
            else return true;
        }
        public void Afisare()
        {
            Console.WriteLine("Ecuatia liniara !");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"{a}X+{b}=0");
            Console.WriteLine($"X={-b/a}");
            Console.WriteLine("--------------------------");
        }
    }
}
