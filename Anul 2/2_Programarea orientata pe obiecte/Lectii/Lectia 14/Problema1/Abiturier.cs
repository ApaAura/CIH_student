using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Abiturier
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string CNP { get; set; }
        public DateOnly Data_Nasterii { get; set; }
        public DateOnly Data_Inregistrarii { get; set; }
        public string Specialitatea { get; set; }
        public double Media { get; set; }
        public void Citire()
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Introduceti datele despre abiturient : ");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Nume : ");
                    Nume = Console.ReadLine();
                    Console.Write("Prenume : ");
                    Prenume = Console.ReadLine();
                    Console.Write("Adresa : ");
                    Adresa = Console.ReadLine();
                    Console.Write("CNP-ul : ");
                    CNP = Console.ReadLine();
                    Console.Write("Data nasterii : ");
                    Data_Nasterii = DateOnly.Parse(Console.ReadLine());
                    Console.Write("Data inregistrarii : ");
                    Data_Inregistrarii = DateOnly.Parse(Console.ReadLine());
                    Console.Write("Specialitatea : ");
                    Specialitatea = Console.ReadLine();
                    Console.Write("Media : ");
                    Media = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare !");
                    isValid = false;
                }
            }
        }
        public int VarstaAbiturient() => DateTime.Now.Year - Data_Nasterii.Year;
        public void Afisare()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Datele despre abiturient : ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Nume Prenume: {Nume} {Prenume}");
            Console.WriteLine($"CNP-ul : {CNP}");
            Console.WriteLine($"Adresa : {Adresa}");
            Console.WriteLine($"Data nasterii : {Data_Nasterii}");
            Console.WriteLine($"Data inregistrarii : {Data_Inregistrarii}");
            Console.WriteLine($"Specialitatea : {Specialitatea}");
            Console.WriteLine($"Media : {Media}");
        }
    }
}
