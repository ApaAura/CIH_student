using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class SmartPhone
    {
        public string Producator { get; set; }
        public string Model { get; set; }
        public int Pret { get; set; }
        public SmartPhone()
        {
        }
        public SmartPhone(string producator, string model, int pret)
        {
            Producator = producator;
            Model = model;
            Pret = pret;
        }
        public SmartPhone(SmartPhone smart)
        {
            Producator=smart.Producator;
            Model=smart.Model;
            Pret = smart.Pret;
        }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele : ");
            Console.Write("Producator : ");
            Producator =Console.ReadLine();
            Console.Write("Model : ");
            Model = Console.ReadLine(); 
            Console.Write("Pret : ");
            Pret = int.Parse(Console.ReadLine());
        }
        //1 euro = 20.88 lei
        public double PretEuro() =>Pret/20.88;
        public void Afisare()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Datele telefonului : ");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Producator : {Producator}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Pretu in lei : {Pret}");
            Console.WriteLine($"Pretul in euro :{PretEuro():F4} ");
        }
    }
}
