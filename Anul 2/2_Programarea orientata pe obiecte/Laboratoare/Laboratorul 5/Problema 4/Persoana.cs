using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Persoana
    {
        public string Nume { get; set; }
        public DateTime dataNasterii { get; set; }
        public void CitireDate()
        {
            Console.Write("Nume : ");
            Nume=Console.ReadLine();
            Console.Write("Data nasterii : ");
            dataNasterii = DateTime.Parse(Console.ReadLine());
        }
        public int Varsta() => DateTime.Now.Year - dataNasterii.Year;
        public void AfisareDate()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Datele persoanei : ");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Nume : {Nume}");
            Console.WriteLine($"Varsta : {Varsta()}");
        }
    }
}
