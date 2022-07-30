using System;
using System.IO;
using System.Linq;

namespace Problema3
{
    struct Elev
    {
        public string nume;
        public string prenume;
        public double notaMed;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // De la tastatură se citesc datele a trei elev: numele, prenumele și nota medie la o disciplină.Să se scire într-un fișier text doar elevii ce au nota maximă.
            Elev[] tab = new Elev[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduceti date elevului {0}", i);
                Console.Write("Nume:");
                tab[i].nume = Console.ReadLine();
                Console.Write("Prenume:");
                tab[i].prenume = Console.ReadLine();
                Console.Write("Nota Medie:");
                tab[i].notaMed = double.Parse(Console.ReadLine());
            }
            double[] t = new double[3];
            for (int i = 0; i < 3; i++)
            {
                t[i] = Convert.ToInt32(tab[i].notaMed);
            }
            double max = t.Max();

            using (StreamWriter wr = new StreamWriter("Fisier.txt"))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (max == tab[i].notaMed) wr.WriteLine("{0} {1} {2}", tab[i].nume, tab[i].prenume, tab[i].notaMed);
                }
            }
            Console.ReadKey();
        }
    }
}
