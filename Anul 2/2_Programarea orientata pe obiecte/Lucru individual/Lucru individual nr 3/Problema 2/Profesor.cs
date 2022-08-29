using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Profesor : Persoana
    {
        public List<string> ListaDiscipline { get; set; }
        public int anulAngajarii { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele angajatului : ");
            base.Citire();
            Console.Write("Numarul de dispipline predate : ");
            int nr=int.Parse(Console.ReadLine());
            List<string> ListaDiscipline = new List<string>();
            Console.WriteLine($"Introduceti {nr} discipline : ");
            string disciplina;
            for (int i = 0; i < nr; i++)
            {
                disciplina = Console.ReadLine();
                ListaDiscipline.Add(disciplina);
            }
            Console.Write("Anul angajarii : ");
            anulAngajarii = int.Parse(Console.ReadLine());
        }
        public int Stagiu()
        {
            return DateTime.Now.Year-anulAngajarii;   
        }
        public void Afisare()
        {
            Console.WriteLine("Datele profesorului : ");
            base.Afisare();
            Console.WriteLine($"Stagiu : {Stagiu()}");
            Console.WriteLine("Discipline predate : ");
            foreach (var item in ListaDiscipline)
            {
                Console.Write(item+" ");
            }
        }
    }
}
