using System;

namespace Prob_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Se citeşte de la tastatură un număr întreg, care corespunde numărului de 
              ordine al lunii anului. Să se afişeze la ecran denumirea corespunzatoare a acestei luni.
             */
            //citim datele 
            int a;
            Console.Write("Introduceti un numar : ");
            a = int.Parse(Console.ReadLine());
            //Instructiunea de decizie multipla SWITCH
            switch (a)
            {
                case 1: Console.Write("Ianuarie"); break;
                case 2: Console.Write("Februarie"); break;
                case 3: Console.Write("Martie"); break;
                case 4: Console.Write("Aprilie"); break;
                case 5: Console.Write("Mai"); break;
                case 6: Console.Write("Iunie"); break;
                case 7: Console.Write("Iulie"); break;
                case 8: Console.Write("August"); break;
                case 9: Console.Write("Septebrie"); break;
                case 10: Console.Write("Octombrie"); break;
                case 11: Console.Write("Noiembrie"); break;
                case 12: Console.Write("Decembrie"); break;

                default: Console.Write("Anul are 12 luni !"); break;
            }
            Console.ReadKey();
        }
    }
}
