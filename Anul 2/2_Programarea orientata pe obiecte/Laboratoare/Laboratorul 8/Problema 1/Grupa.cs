using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele elevului: ");
            Console.Write("Numele : ");
            Nume= Console.ReadLine();
            Console.Write("Prenumele : ");
            Prenume= Console.ReadLine();
        }
    }
    class Grupa : Elev
    {
        public string Nume { get; set; }
        public List<Elev> Elevi { get; set; }
        public Grupa()
        {
            Elevi = new List<Elev>();
        }
        public void Citire()
        {
            base.Citire();
            Console.Write("Grupa : ");
            Nume= Console.ReadLine();   
            Elevi.Add(new Elev());
        }
        public static Grupa operator +(Grupa G1,Grupa G2)
        {
            Grupa rezultat = new Grupa(); 
            rezultat.Nume = G1.Nume+", "+G2.Nume;
            foreach (Elev  elev in G1.Elevi)
            {
                rezultat.Elevi.Add(elev);
            }
            foreach (Elev elev in G2.Elevi)
            {
                rezultat.Elevi.Add(elev);
            }
            return rezultat;
        }
        public static bool operator ==(Grupa G1,Grupa G2)
        {
            return G1.Elevi.Count==G2.Elevi.Count;
        }
        public static bool operator !=(Grupa G1, Grupa G2)
        {
            return G1.Elevi.Count != G2.Elevi.Count;
        }
    }
}
