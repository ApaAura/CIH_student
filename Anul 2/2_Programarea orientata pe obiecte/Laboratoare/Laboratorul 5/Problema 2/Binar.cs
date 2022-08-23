using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
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
    public class Dreptunghi : Binar
    {
        public Dreptunghi(int a, int b) : base(a, b)
        {
        }
        public double Aria() => a * b;
        public double Perimetru() => 2*(a+b);
        public void Afisare()
        {
            Console.WriteLine($"Lungimea : {a}\nLatimea : {b}");
            Console.WriteLine($"Aria : {Aria()}\nPerimetrul : {Perimetru()}");
        }
    }
}
