using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// Resgistros de incidencias de soporte tecnico utilizando archivos (.txt)
// 1. Guardar en una lista de incidencias atendias en un archivo de texto (incidencias.txt)
// 2. Leer el archivo 
// 3. Generar un reporte que cuanta cuantas incidencias hay por prioridad (Alta, Media, Baja).
// la estructura del archivo es : ID, NOMBRE, DESCRIPCION, PRIORIDAD.

// Ejemplo: ´01´; ``
namespace registros
{
    internal class Program
    {

        //C:\User\SALA-1\Desktop
        //Creado ruta para guardar mis incidencias.
        static string pathArchivo = "incidencias.txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {
                        sw.WriteLine(string.Join(";", incidencia));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (!File.Exists(pathArchivo))
            {
                Console.WriteLine("el archivo no existe aun. ");
                return incidencias;
            }
            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathArchivo))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo {ex.Message}");
            }

            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencias para reportar. ");
                return;
            }
            Dictionary<string, int> conteoPorPrioridad = new Dictionary<string, int>();

            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                //inc[`01`; `Stevel Orellano`; `Daño del PC`; `Alta`]
                if (conteoPorPrioridad.ContainsKey(prioridad))
                {
                    conteoPorPrioridad[prioridad]++;
                }
                else
                {
                    conteoPorPrioridad[prioridad] = 1;
                }
            }

            Console.WriteLine("\nREPORTE DE INCIDENCIAS");
            Console.WriteLine($"Total Atendidas: {incidencias.Count}");
            Console.WriteLine("Detalle por prioridad");
            foreach (var item in conteoPorPrioridad)
            {
                Console.WriteLine($"Prioridad {item.Key}: {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] {"1", "Stevel Orellano", "Falla de red", "Media"},
                new string[] {"2", "Jose Arcon", "Impresora rota", "Baja"},
                new string[] {"3", "Oscar Hernandez", "Pantalla azul", "Alta"},
                new string[] {"4", "Luis Torres", "Cambio de clave", "Baja"},
                new string[] {"5", "Sofia Martinez", "piratear Office xd", "Media"},
            };

            Console.WriteLine("REGISTRO DE INCIDENCIAS UNICARIBE");
            GuardarIncidencias(incidenciasToday);

            Console.WriteLine("\n ||||| Leyendo incidencias |||||");
            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIAS LEIDAS: ");
            Console.WriteLine($"{"ID",-4}{"Usuario",-15}{"Descripcion",-20}{"Prioridad",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasLeidas)
            {
                if(inc.Length > 4) continue;
                Console.WriteLine($"{inc[0],-4} {inc[1],-15} {inc[2],-20} {inc[3],-10}");
            }
            GenerarReporte(incidenciasLeidas);
            Console.WriteLine("\nPresione cualquier tecla para salir!!!!!");
            Console.ReadKey();


        }
    }
}
