using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = new int[20];
            Console.WriteLine("ingrese los codigos:");
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"codigo {i + 1}: ");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"codigos actuales: {string.Join(", ", codigos)}");
            Console.WriteLine($"pon el codigo que sea actualizar: ");
            int busqueda = Convert.ToInt32(Console.ReadLine());
            int indiceEncontrado = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            if (indiceEncontrado != -1)
            {
                Console.WriteLine("ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector Actualizado: {string.Join(", ", codigos)}");
            }
            else
            {
                Console.WriteLine("\nError: el codigo ingresado no existe en la BDD");
            }
            Console.WriteLine($"\n valor del indice: {indiceEncontrado}");
        }
    }
}


