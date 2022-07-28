using System;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este dat un număr întreg n. Să se determine suma cifrelor pare din scrierea acestui număr.
            //Este dat un număr întreg n. Să se afișeze la ecran ultima cifră din scrierea acestui număr.

            Console.WriteLine("Inreoduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            //ultima cifra a numarului
            Console.WriteLine("Ultima cifra a numarului: {0}",n%10);
            int SumaPare = 0;
            //Instructiunea while este folosita cand nu cunoastem numarul de iteratii
            //respectiv lungimea numarului n
            while (n!=0)
            {
                //verificam daca ultima cifra a lui n este para
                if ((n%10)%2==0)
                {
                    SumaPare += n%10;
                }
                n /= 10;
            }
            //Afisam rezultatul 
            Console.WriteLine("Suma cifrelor pare este {0}", SumaPare);

           
        }
    }
}
