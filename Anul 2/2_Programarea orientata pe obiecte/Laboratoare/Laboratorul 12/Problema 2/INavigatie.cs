using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal interface INavigatie
    {
        public string ModelGPS { get; set; }
        public void Localizeaza();
    }
}
