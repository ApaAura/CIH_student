using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_1
{
    class Cerc
    {
        public int lungimeaRazei;
        public void Citire()
        {
            lungimeaRazei = int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine($"Lungimea razei: {lungimeaRazei}");
        }
        public double Lungime(int lungimeaRazei) => 2 * Math.PI * lungimeaRazei;
        public double Suprafata(int lungimeaRazei) => Math.PI * lungimeaRazei;
        public double Diametru() => lungimeaRazei * 2;
    }
}
