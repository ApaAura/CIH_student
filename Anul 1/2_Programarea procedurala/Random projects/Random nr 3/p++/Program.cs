using System;

namespace p__
{
    class Program
    {
        public static int Stotal;
        public static int Sanexe;
        public static int pret;

        static void Main(string[] args)
        {
            //At=2(L*l+L*h+l*h)
            Citire();
             int arie = SupTotal();
            Console.WriteLine($"Suprafata totala este : {arie}");
            Console.WriteLine($"Pretul total al tapetelor este: {arie*pret}");
        }
        private static int SupTotal()
        {
            int a = 0;
            a = Stotal - Sanexe;
            return a;
        }
        private static void Citire()
        {
            Console.WriteLine("Introduceti datele camerei. ");
            Console.Write("Inaltime: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Lungime: ");
            int lung = int.Parse(Console.ReadLine());
            Console.Write("Latime: ");
            int lat = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti dimensiunile usii. ");
            Console.Write("Inaltime: ");
            int u1= int.Parse(Console.ReadLine());
            Console.Write("Latime: ");
            int u2 = int.Parse(Console.ReadLine());
            int Susa = u1 * u2;
            Console.WriteLine("Introduceti dimensiunile ferestrei.");
            Console.Write("Inaltime: ");
            int f1 = int.Parse(Console.ReadLine());
            Console.Write("Latime: ");
            int f2 = int.Parse(Console.ReadLine());
            int Sfereastra = f1*f2;
            Sanexe = Sfereastra + Susa;
            Stotal = 2 * (h * lung + h * lat + lung * lat);
            Console.Write("Pret m patrat tapet: ");
            pret = int.Parse(Console.ReadLine());
        }
    }
}
