using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Punct
    {
        public double x { get; set; }
        public double y { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti coordonatele : ");
            Console.Write("x = ");
            x=int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y=int.Parse(Console.ReadLine());
        }
        public static Punct operator +(Punct a, Punct b)
        {
            return new Punct()
            {
                x = a.x + b.x,
                y = a.y + b.y
            };
        }
        public static Punct operator -(Punct a, Punct b)
        {
            return new Punct()
            {
                x = a.x - b.x,
                y = a.y - b.y
            };
        }
        public static Punct operator *(Punct a, Punct b)
        {
            return new Punct()
            {
                x = a.x * b.x,
                y = a.y * b.y
            };
        }
        public static Punct operator /(Punct a, Punct b)
        {
            return new Punct()
            {
                x = a.x / b.x,
                y = a.y / b.y
            };
        }
        public static bool operator ==(Punct a,Punct b)
        {
            return a.x == b.x&&a.y==b.y;
        }
        public static bool operator !=(Punct a, Punct b)
        {
            return a.x != b.x || a.y != b.y;
        }
        public override string ToString()
        {
            return $"({this.x},{this.y})";
        }
    }
}
