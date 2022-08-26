using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Cladire
    {
        public string Nume { get; set; }
        public string Contractant { get; set; }
        public double Pret { get; set; }
        public DateTime DataSemnariiContractului { get; set; }

        public void Citire()
        {
            Console.Write("Nume : ");
            Nume=Console.ReadLine();
            Console.Write("Contractant : ");
            Contractant=Console.ReadLine();
            Console.Write("Pret : ");
            Pret=double.Parse(Console.ReadLine());
            Console.Write("Data semnarii contractului : ");
            DataSemnariiContractului= DateTime.Parse(Console.ReadLine());   
        }
        public virtual void Materiale()
        {
            Console.WriteLine("Lemn");
            Console.WriteLine("Ciment");
            Console.WriteLine("Nisip");
            Console.WriteLine("Combustibil");
        }
    }
}
