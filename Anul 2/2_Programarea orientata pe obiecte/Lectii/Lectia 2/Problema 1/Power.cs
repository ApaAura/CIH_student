using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Power
    {
        //constructor fara parametru
        public Power()
        {
        }
        //constructor cu parametru
        public Power(int nr1, int nr2)
        {
            this.Nr1 = nr1;
            this.Nr2 = nr2;
        }
        //constructor de copiere
        public Power(Power pr)
        {
            this.Nr1 = pr.Nr1;
            this.Nr2 = pr.Nr2;
        }
        public int Nr1 { get; set; }
        private int nr2;
        public int  Nr2 
        {
            get { return nr2; }
            set
            {
                if (value == 0)
                    throw new Exception();
                else
                    nr2 = value;
            } 
        }
        public void Citire()
        {
            Console.Write("Introduceti nr1: ");
            Nr1=int.Parse(Console.ReadLine());
            Console.Write("Introduceti nr2: ");
            Nr2 =int.Parse(Console.ReadLine());
        }
        public double Powers() => Math.Pow(Nr1, nr2);   
        public void Afisare()
        {
            Console.WriteLine($"{Nr1}^{Nr2}={Powers()}");
        }
    }
}
