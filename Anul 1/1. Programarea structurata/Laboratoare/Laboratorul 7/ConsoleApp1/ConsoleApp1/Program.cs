using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              De la tastatură se citește un număr pozitiv, mai mic sau egal cu 100. 
              Elaborați un program care va afișa numărul citit cu cifre romane.
            */

            int x;
            Console.Write("Introduceti un numar: ");
            x = int.Parse(Console.ReadLine());

            int zeci, unitati;
            zeci = x / 10;
            if (x>=10)
            {
                unitati = x % 10;
            }
            else
            {
                unitati = x;
            }
            string zeciRoman = "", unitatiRoman = "";
            switch (unitati)
            {
                case 1 : unitatiRoman = "I";break;
                case 2 : unitatiRoman = "II"; break;
                case 3 : unitatiRoman = "III"; break;
                case 4 : unitatiRoman = "IV"; break;
                case 5 : unitatiRoman = "V"; break;
                case 6 : unitatiRoman = "VI"; break;
                case 7 : unitatiRoman = "VII"; break;
                case 8 : unitatiRoman = "VIII"; break;
                case 9 : unitatiRoman = "IX"; break;
                case 10 : unitatiRoman = "X"; break;
                default: unitatiRoman = "";break;
            }
            switch (zeci)
            {
                case 1: zeciRoman = "X"; break;
                case 2: zeciRoman = "XX"; break;
                case 3: zeciRoman = "XXX"; break;
                case 4: zeciRoman = "XL"; break;
                case 5: zeciRoman = "L"; break;
                case 6: zeciRoman = "LX"; break;
                case 7: zeciRoman = "LXX"; break;
                case 8: zeciRoman = "LXXX"; break;
                case 9: zeciRoman = "XC"; break;
                case 10: zeciRoman = "C"; break;
            }
            Console.WriteLine($"{zeciRoman}{unitatiRoman}");
            Console.ReadKey();
        }
    }
}
