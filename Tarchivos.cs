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
            string path = "ventas.csv";

            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] {
                    "Gaseosa,15",
                    "Pastelito,8",
                    "Salchipapa,30",
                    "Jugo,12"
                });
            }

            string[] lines = File.ReadAllLines(path);
            int total = 0;
            string masProd = "";
            int maxCant = -1;

            foreach (string l in lines)
            {
                string[] p = l.Split(',');
                
                if (p.Length == 2)
                {
                    string prod = p[0].Trim();
                    int cant = int.Parse(p[1].Trim());

                    total += cant;

                    if (cant > maxCant)
                    {
                        maxCant = cant;
                        masProd = prod;
                    }
                }
            }

            Console.WriteLine($"total unidades: {total}");
            Console.WriteLine($"mas vendido: {masProd} ({maxCant})");
        }
    }
}
