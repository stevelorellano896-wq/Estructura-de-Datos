using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\sala-1.UNICARIBE\\Desktop\\trabajos de archivos\\productos_xd.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID, Nombre, Precio, Categoria");
            sw.WriteLine("1, Teclado Mecanico ,85, Perifericos");
            sw.WriteLine("2, Silla Gamer, 250, Mobiliario");
            sw.WriteLine("3, Audifonos, 150, Audio");
        }

        string[] lineas = File.ReadAllLines(ruta);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double precio = double.Parse(campos[2]);
            if (precio > 100)
            {
                Console.WriteLine($"{campos[1]} - ${precio}");
            }
        }
    }
}
