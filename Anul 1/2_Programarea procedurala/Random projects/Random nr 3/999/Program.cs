using System;
using System.Linq;

namespace _999
{
    class Program
    {
        struct calculator
        {
           public double frecventa;
           public double viteza;
            public void Cit()
            {
                Console.Write("F: ");
                frecventa = double.Parse(Console.ReadLine());
                Console.Write("v: ");
                viteza = double.Parse(Console.ReadLine());
            }
            public void Afisare()
            {
                Console.WriteLine($"Frecventa: {frecventa}");
                Console.WriteLine($"Viteza: {viteza}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti nr de calculatoare: ");
            int nr = int.Parse(Console.ReadLine());
            calculator[] x = new calculator[nr];
            for (int i = 0; i < nr; i++)
            {
                x[i].Cit();
            }
            double max = x.Max(f => f.frecventa);
            for (int i = 0; i < nr; i++)
            {
                if (x[i].frecventa==max)
                {
                    x[i].Afisare();
                }
            }
            Console.ReadKey();
        }
    }
}
