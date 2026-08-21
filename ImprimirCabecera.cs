using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kof
{
    internal class Program
    {
        static void ImprimirCabecera(string nombreMateria, int grupo, string NombreEstudiante)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("  Universidad Del Caribe      ");
            Console.WriteLine("  Stevel Orellano");
            Console.WriteLine($"  Asignatura: {nombreMateria}");
            Console.WriteLine($"  Grupo: {grupo}");
            Console.WriteLine("================================");
        }

        public static void Main(string[] args)
        {
            ImprimirCabecera("Fundamentos de Programacion", 1, "Stevel Orellano");
        }
    }
}


