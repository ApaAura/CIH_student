using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class AppLogic
    {
        public List<Abiturier> ListaAbiturienti { get; set; }
        bool flag = true;
        int AlegereUtilizator = 0;

        public AppLogic()
        {
            ListaAbiturienti = new List<Abiturier>();
        }

        public void AfisareMeniu()
        {
            
            Console.WriteLine("  \t\t\t\t\t Meniul:");
            Console.WriteLine("\t\t\t1. Citire lista abiturieri.");
            Console.WriteLine("\t\t\t2. Afisare top 3 abiturieri.");
            Console.WriteLine("\t\t\t3. Exclude un abiturier dupa CNP. ");
            Console.WriteLine("\t\t\t4. Afisare top 3 abiturieri cu cele mai mici medii. ");
            Console.WriteLine("\t\t\t5. Lista abiturierilor cu varsta sub 18 ani.");
            Console.WriteLine("\t\t\t6. Lista abiturierilor cu varsta peste 18 ani.");
            Console.WriteLine("\t\t\t7. Lista abiturierilor in ordine descrescatoare a mediilor.");
            Console.WriteLine("\t\t\t8. Iesire.");
            Console.WriteLine();
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.WriteLine("========================================");
                    Console.Write("\tIntroduceti comanda: ");
                    AlegereUtilizator = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Comanda invalida!\nIntroduceti alta comanda.");
                    isValid = false;
                }
            }
        }

        private void BussinesLogic()
        {
            switch (AlegereUtilizator)
            {
                case 1: CitireLista(); break;
                case 2: Top3Good(); break;
                case 3: ExcludeCNP(); break;
                case 4: Top3Bad(); break;
                case 5: Plus18(); break;
                case 6: Minus18(); break;
                case 7: ListaDescrescatoare(); break;
                case 8: flag = false; Console.WriteLine("Aplicatia a fost inchisa!"); break;
                default: Console.WriteLine("Comanda necunoscuta!"); break;
            }
            Console.ReadKey();
            Console.Clear();
        }

        private void CitireLista()
        {
            Console.Write("Introduceti numarul de abiturieri : ");
            bool isValid = false;
            int nr = 0;
            while (!isValid)
            {
                try
                {
                    nr = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Introduceti un numar !");
                    isValid = false;
                }
            }
            Abiturier newAbiturier;
            for (int i = 0; i < nr; i++)
            {
                newAbiturier = new Abiturier();
                newAbiturier.Citire();
                ListaAbiturienti.Add(newAbiturier);
            }
        }

        private void Top3Good()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Lista abiturientilor cu cele mai mari medii: ");
            Console.WriteLine("--------------------------------");
            ListaAbiturienti = ListaAbiturienti.OrderByDescending(x => x.Media).ToList();
            for (int i = 0; i <= 2; i++)
            {
                ListaAbiturienti[i].Afisare();
            }
        }

        private void ExcludeCNP()
        {
            Console.Write("Introduceti un CNP: ");
            string CNPexclude=Console.ReadLine();
            Abiturier toRemove = ListaAbiturienti.SingleOrDefault(x => x.CNP == CNPexclude);
            ListaAbiturienti.Remove(toRemove);
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Abiturientul cu CNP-ul {CNPexclude} a fost exclus !");
            Console.WriteLine("--------------------------------");
        }

        private void Top3Bad()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Lista abiturientilor cu cele mai mici medii: ");
            Console.WriteLine("--------------------------------");
            ListaAbiturienti = ListaAbiturienti.OrderBy(x => x.Media).ToList();
            for (int i = 0; i <= 2; i++)
            {
                ListaAbiturienti[i].Afisare();
            }
        }
      
        private void Plus18()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Lista abiturientilor cu varsta mai mare de 18 : ");
            Console.WriteLine("--------------------------------");
            foreach (Abiturier item in ListaAbiturienti)
            {
                if (item.VarstaAbiturient()>=18)
                {
                    item.Afisare();
                }
            }
        }

        private void Minus18()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Lista abiturientilor cu varsta mai mica de 18 : ");
            Console.WriteLine("--------------------------------");
            foreach (Abiturier item in ListaAbiturienti)
            {
                if (item.VarstaAbiturient() < 18)
                {
                    item.Afisare();
                }
            }
        }

        private void ListaDescrescatoare()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Lista descrescatoare a abiturientilor dupa medie : ");
            Console.WriteLine("--------------------------------");
            ListaAbiturienti = ListaAbiturienti.OrderByDescending(x => x.Media).ToList();
            foreach (Abiturier item in ListaAbiturienti)
            {
                item.Afisare();
            }
        }
        
        public void Start()
        {
            while (flag)
            {
                AfisareMeniu();
                BussinesLogic();
            }
        }
    }
}
