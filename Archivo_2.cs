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
         string ruta = "C:\\Users\\sala-1.UNICARIBE\\Desktop\\trabajos de archivos\\estudiantes_xd.csv";
         if (File.Exists(ruta))
         {
             string[] lineas = File.ReadAllLines(ruta);
             foreach (string linea in lineas)
              {
                  string[] campos = linea.Split(',');
                  Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}, Carrera: {campos[3]}");
              }
         }
         using (StreamWriter sw = new StreamWriter("C:\\Users\\sala-1.UNICARIBE\\Desktop\\trabajos de archivos\\estudiantes_xd.csv", append: true))
         {
          sw.WriteLine("Carlos,20,4.5,Sistemas");
          sw.WriteLine("Maria,22,4.8,Industrial");
         }

     }

}
