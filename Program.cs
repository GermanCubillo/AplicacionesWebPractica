using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            numeros numero = new numeros();
            numero.Numero = 11;
            if (numero.Numero %2 == 0)
            {
                Console.WriteLine(numero.NumeroPar());
            }
            else
            {
                Console.WriteLine(numero.NumeroImpar());
            }
            Console.ReadKey();
        }
    }
}
