using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal interface ISistemAudio
    {
        public string ModelSistemAudio { get; set; }
        public void Canta();
    }
}
