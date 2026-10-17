using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd.css
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\sala-1.UNICARIBE\\Desktop\\trabajos de archivos\\estudiantes_xd.csv" ;
            using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine("Nombre, Edad, Nota, Asignatura");
                    sw.WriteLine("Jose, 19, 2.3, Fisica Electrica ");
                    sw.WriteLine("Oscar, 18, 4, Estructura de Datos");
                    sw.WriteLine("Stevel, 17, 5, Calculo Diferencial");
                    sw.WriteLine("Juanchito, 15, 3.4, Sistemas Informaticos");
                }
                Console.WriteLine("Archivo creado exitosamente :D");
            }
        }

}
