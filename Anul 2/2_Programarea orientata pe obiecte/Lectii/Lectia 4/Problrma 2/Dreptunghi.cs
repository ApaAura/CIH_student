using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problrma_2
{
    public  class Dreptunghi
    {
        public int lungime { get; set; }
        public int latime { get; set;}
        public void Citire()
        {
            Console.WriteLine("Introduceti datele : ");
            Console.Write("Lungime : ");
            lungime=int.Parse(Console.ReadLine());
            Console.Write("Latime : ");
            latime=int.Parse(Console.ReadLine());
        }
        public int Perimetru() => 2 * lungime + 2 * latime;
        public int Aria() => lungime * latime;
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine("Datele dreptunghiului : ");
            Console.WriteLine($"Lungime : {lungime}\nLatime : {latime}");
            Console.WriteLine($"Perimetru : {Perimetru()}\nAria : {Aria()}");
            Console.ReadKey();
        }
    }
}
