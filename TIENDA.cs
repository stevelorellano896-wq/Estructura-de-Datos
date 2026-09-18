using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ventas = { 200.000, 302.300, 400.000, 300.233, 700.410, 740.432, 100.233, 99.423, 823.231, 902.211 };
            double total = 0;
            double mayorVenta = ventas[0];
            double menorVenta = ventas[0];
            int diaMayorVenta = 0;
            int diaMenorVenta = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];

                if (ventas[i] > mayorVenta)
                {
                    mayorVenta = ventas[i];
                    diaMayorVenta = i;
                }
                if (ventas[i] < menorVenta)
                {
                    menorVenta = ventas[i];
                    diaMenorVenta = i;
                }
            }

            double promedio = total / ventas.Length;
            int diaSobrePromedio = 0;

            for (int i = 0; ventas.Length > i; i++)
            {
                if (ventas[i] > promedio)
                {
                    diaSobrePromedio++;
                }
            }

            Console.WriteLine("===============Reporte de ventas================");
            Console.WriteLine();

            Console.WriteLine($"total vendido: ${total:F2}");
            Console.WriteLine($"promedio diario: ${promedio:F2}");
            Console.WriteLine();

            Console.WriteLine($"mayor venta ${mayorVenta:F2} - el dia {diaMayorVenta + 1}");
            Console.WriteLine($"menor venta ${menorVenta:F2} - el dia {diaMenorVenta + 1}");

            Console.WriteLine($"dias que superaron el promedio de ventas: ${diaSobrePromedio}");
            Console.WriteLine();


            Console.WriteLine("ventas por dias");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"dia {i + 1}: ${ventas[i]:F3}");
            }
        }
    }
}
