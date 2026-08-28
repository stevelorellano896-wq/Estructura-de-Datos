using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goku
{
    internal class Program
    {

        public static void ImprimirSuma (int a, int b)
        {
            int suma = a + b;
            Console.WriteLine (suma);
        }

        public static void MostrarPotenciaX (double num1, double potencia)
        {
            double result = Math.Pow(num1, potencia);
            Console.WriteLine ($"La potencia de {num1} elevado a {potencia} es: {result}");
        }
       




        public static void Main(string[] args)
        {
            int x = 12, y = 13;

            ImprimirSuma(x, y);
            ImprimirSuma(1000, -1);
            MostrarPotenciaX(x, y);
        }
    }
}
