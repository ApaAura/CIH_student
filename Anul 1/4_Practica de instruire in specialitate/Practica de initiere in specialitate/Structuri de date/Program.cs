using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Structuri_de_date
{
    class Program
    {
        public struct Carte
        {
            public string Denumire;
            public string Autor;
            public string Furnizor;
            public double Pret;
            public int Anul_editarii;
            public void Citire()
            {
                try
                {
                    Console.WriteLine("==================================================\n\t\tIntroduceti datele cartii: ");
                    Console.Write("Denumire: ");
                    Denumire = Console.ReadLine();
                    if (Denumire.Length == 0)
                    {
                        throw new Exception();
                    }
                    Console.Write("Autor: ");
                    Autor = Console.ReadLine();
                    if (Autor.Length == 0)
                    {
                        throw new Exception();
                    }
                    Console.Write("Furnizor: ");
                    Furnizor = Console.ReadLine();
                    if (Furnizor.Length == 0)
                    {
                        throw new Exception();
                    }
                    Console.Write("Pret: ");
                    Pret = int.Parse(Console.ReadLine());
                    if (Pret == double.NaN)
                    {
                        throw new Exception();
                    }
                    Console.Write("Anul editarii: ");
                    Anul_editarii = int.Parse(Console.ReadLine());
                    if (Anul_editarii == 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare! Inroduceti date veridice. ");
                    Console.ReadKey();
                    Console.Clear();
                    Citire();
                }
            } 
            public void Afisare()
            {
                Console.WriteLine("============= Datele cartii =============");
                Console.WriteLine($"\t\tDenumire: {Denumire}");
                Console.WriteLine($"\t\tAutor: {Autor}");
                Console.WriteLine($"\t\tFurnizor: {Furnizor}");
                Console.WriteLine($"\t\tPret: {Pret}");
                Console.WriteLine($"\t\tAnul editarii: {Anul_editarii}");
                Console.WriteLine();
            }
        }
        public static Carte[] masiv;
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("  \t\t\t\t\t Meniul:");
                Console.WriteLine("\t\t\t1. Adaugati carti.");
                Console.WriteLine("\t\t\t2. Adaugati cartile in fiser binar.");
                Console.WriteLine("\t\t\t3. Introducerea datelor din fisier binar. ");
                Console.WriteLine("\t\t\t4. Afisarea datelor citite din fisier binar. ");
                Console.WriteLine("\t\t\t5. Afisati cartile, denumirea carora se incepe cu o consoana.");
                Console.WriteLine("\t\t\t6. Iesire.");
                Console.WriteLine();
                bool isValid = false;
                int c = 0;
                while (!isValid)
                {
                    try
                    {
                        Console.WriteLine("========================================");
                        Console.Write("\tIntroduceti comanda: ");
                        c = int.Parse(Console.ReadLine());
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Comanda invalida!\nIntroduceti alta comanda.");
                        isValid = false;
                    }
                }
                switch (c)
                { 
                    case 1: Citire(); break;
                    case 2: ScriereFisier(); break;
                    case 3: CitFisier(); break;
                    case 4: Afisare(); break;
                    case 5: Consoana(); break;
                    case 6: flag = false; Console.WriteLine("Aplicatia a fost inchisa!"); break;
                    default: Console.WriteLine("Comanda necunoscuta!"); break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static void Consoana()
        {
            string consoane = "bcdfhjklmnpqrstvwxzy";
            var sh = from c in masiv.ToList() where c.Furnizor.Contains("Prut") && consoane.Contains(c.Denumire[0].ToString().ToLower()) select c;
            if (sh.Count() != 0)
            {
                Console.WriteLine("Lista  cartilor denumirea carora incepe cu o consoana:\n=========================================");
                foreach (var item in sh)
                {
                    item.Afisare();
                }
            }
            else
            {
                Console.WriteLine("Nu au fost gasite carti care sa indeplinesca conditia");
            }
        }
        private static void Afisare()
        {
            foreach (var item in masiv)
            {
                item.Afisare();
            }
        }
        private static void CitFisier()
        {
            if (File.Exists("date.bin"))
            {
                if (File.ReadAllText("date.bin")!=null)
                {
                    try
                    {
                        using (BinaryReader br = new BinaryReader(new FileStream("date.bin", FileMode.Open)))
                        {
                            int nr = br.ReadInt32();
                            masiv = new Carte[nr];
                            for (int i = 0; i < nr; i++)
                            {
                                masiv[i].Denumire = br.ReadString();
                                masiv[i].Autor = br.ReadString();
                                masiv[i].Furnizor = br.ReadString();
                                masiv[i].Pret = br.ReadDouble();
                                masiv[i].Anul_editarii = br.ReadInt32();
                            }
                            Console.WriteLine("Datele au fost citite cu succes !");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Fisierul a fost gasit, insa nu este formatat corect.");
                    }
                }
                else
                {
                    Console.WriteLine("Fisierul a fost gasit, insa nu este formatat corect.");
                }
            }
            else
            {
                Console.WriteLine("Fisierul nu a fost gasit.");
            }
        }
        private static void ScriereFisier()
        {
            try
            {
                if (masiv.Length!=0)
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream("date.bin", FileMode.Create)))
                    {
                        bw.Write(masiv.Length);
                        foreach (var item in masiv)
                        {
                            bw.Write(item.Denumire);
                            bw.Write(item.Autor);
                            bw.Write(item.Furnizor);
                            bw.Write(item.Pret);
                            bw.Write(item.Anul_editarii);
                        }
                    }
                    Console.WriteLine("Fisierul a fost creat cu succes !");
                }
                else
                {
                    Console.WriteLine("Asigurati-va ca a-ti inregistrat cartile mai intai.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ceva nu a mers cum trebuie, m-ai incercati o data");
            }
        }
        private static void Citire()
        {
            try
            {
                Console.Write("Numarul de carti: ");
                int nr = int.Parse(Console.ReadLine());
                masiv = new Carte[nr];
                Console.WriteLine("Introduceti datele despre carti: ");
                Console.WriteLine();
                for (int i = 0; i < nr; i++)
                {
                    masiv[i].Citire();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Eroare! Inroduceti date veridice. ");
                Console.ReadKey();
                Console.Clear();
                Citire();
            }
            Console.Clear();
        }
    }
}
