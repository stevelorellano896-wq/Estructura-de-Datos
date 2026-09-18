using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd 
{
    internal class Program
    {
        static double CalcularAreaCirculo(double radio)
        {
            const double PI = 3.141592;
           
            double area = PI * Math.Pow(radio, 2);
            return area;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Inrese el radio del circulo: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = CalcularAreaCirculo(r);
            Console.WriteLine($"el area es: {result:F2}");

        }
    }
}
