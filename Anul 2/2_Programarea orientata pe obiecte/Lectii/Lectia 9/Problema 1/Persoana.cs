using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
    }
    class Angajat : Persoana
    {
        public string Departament { get; set; }
        public double Salariu { get; set; }
    }
}
