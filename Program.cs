using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba a, b, c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminante = ((b * b) - (4 * a * c));

            if (discriminante == 0)
            {
                double fms = (-b ) / (2 * a);
                Console.WriteLine("El resultado es: " + fms);

            }
            else if ( discriminante > 0)
            {
                double fms = (-b + Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("El resultado es: " + fms);
                double fmr = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("El resultado es: " + fmr);

            }
            else
            {
                Console.WriteLine("No es posible calcular la solución");
            }
        }
    }
}
