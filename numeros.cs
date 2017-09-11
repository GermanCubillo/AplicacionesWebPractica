using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class numeros
    {
        public int Numero { get; set; }

        public string NumeroPar ()
        {
            return "Numero Par: " + Numero;
        }
        public string NumeroImpar()
        {
            return "Numero Impar: " + Numero;
        }
    }
}
