using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_1
{
    class Cerculet
    {
        //campuri
        private double raza;
        private string culoare;
        //proprietati
        public double  Raza 
        {
            get { return raza; } 
            set 
            { 
                if(value>0) 
                    raza = value;
                else
                    raza = 3;
            } 
        }
        public string Culoare
        {
            get { return culoare; }
            set
            {
                if (value.Length!=0)
                    culoare = value;
                else
                    culoare = "Rosu";
            }
        }
        //Read data
        public void Citire()
        {
            Console.Write("Introduceti raza cerculetului: ");
            Raza = double.Parse(Console.ReadLine());
            Console.Write("Introduceti culoarea cerculetului: ");
            Culoare = Console.ReadLine();
        }
        //Display data
        public void Afisare()
        {
            Console.WriteLine($"Raza cerculetului: {Raza}");
            Console.WriteLine($"Culoarea cerculetului: {Culoare}");
            Console.WriteLine($"Diametrul cerculetului: {CalculeazaDiametru():f3}");
            Console.WriteLine($"Aria cerculetului: {CalculeazaAria():f3}");
            Console.WriteLine($"Perimerul cerculetului: {CalculeazaPerimetrul():f3}");

        }
        //private methods
        private double CalculeazaDiametru()
        {
            return raza * 2;
        }
        private double CalculeazaPerimetrul()
        {
            double perimetru = Math.Pow(raza, 2) * 2 * Math.PI;
            return perimetru;
        }
        private double CalculeazaAria()
        {
            double aria = Math.PI * Math.Pow(raza, 2);
            return aria;
        }
    }
}
