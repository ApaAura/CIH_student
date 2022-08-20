using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_3
{
    class Student
    {
        public string nume;
        public int AnulNasterii;
        public int nota1;
        public int nota2;
        public int nota3;
        public void Citire()
        {
            Console.Write("Numele studentului: ");
            nume = Console.ReadLine();

            Console.Write("Anul nasterii: ");
            AnulNasterii = int.Parse(Console.ReadLine());

            Console.Write("Nota la biologie: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Nota la matematica: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Nota la limba romana: ");
            nota3 = int.Parse(Console.ReadLine());

        }
        public void Afisare()
        {
            Console.WriteLine($"Numele: {nume}" );
            Console.WriteLine($"Anul nasterii: {AnulNasterii}");
            Console.WriteLine($"Media curenta {Media()}");
        }
        public int Varsta() 
        { 
           return DateTime.Now.Year - AnulNasterii;
        }
        public double Media() 
        {
          return (nota1 + nota2 + nota3) / 3;
        } 
        public int Restanta()
        {
            if (Media() < 5)
                return 1;
            else
                return 0;
        }
        public int Bursa() 
        {
            if (Media() > 7.5)
                return 500;
            else
                return 0;
        }
    }
}
