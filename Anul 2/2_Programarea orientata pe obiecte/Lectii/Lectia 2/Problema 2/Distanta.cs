using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Distanta
    {
        //constructor fara parametri
        public Distanta()
        {
            X = 0;
            Y = 0;
        }
        //constructor cu parametri
        public Distanta(int x, int y)
        {
            X = x;
            Y = y;
        }
        //constructor de copiere
        public Distanta(Distanta dis)
        {
            X = dis.X;
            Y = dis.Y;
        }

        public int X { get; set; }

        public int Y { get; set; }
        public void Citire()
        {
            Console.Write("Introduceti X: ");
            X=int.Parse(Console.ReadLine());
            Console.Write("Introduceti Y: ");
            Y=int.Parse(Console.ReadLine());    
        }
        public double Distance => Math.Sqrt(Math.Pow((X-0),2)+Math.Pow((Y-0),2));
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine($"Distanata parcursa este : {Distance}");
        }
    }
}
