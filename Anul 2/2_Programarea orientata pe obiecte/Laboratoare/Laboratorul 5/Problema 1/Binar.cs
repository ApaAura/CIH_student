using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    public class Binar
    {
        public Binar(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int a { get; set; }
        public int b { get; set; }
    }
    public class Putere : Binar
    {
        public Putere(int a, int b) : base(a, b)
        {
        }
        public double Pow() => Math.Pow(a, b);
        public void Afisare()
        {
            Console.WriteLine($"{a}^{b}={Pow()}");
        }
    }
}
