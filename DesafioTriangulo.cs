using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese b, z, y: ");
            double bgrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double t = (Math.Sqrt((z * z) + (y * y)));

            double sinC = (z / t);
            double c = Math.Asin(sinC);
            double cGrados = c * (180.0 / Math.PI);

            double eGrados = (180 - cGrados);

            double dGrados = (180 - eGrados - bgrados );

            double b = bgrados * (Math.PI / 180.0);
            double d = dGrados * (Math.PI / 180.0);

            double x = ((t * Math.Sin(b)) / Math.Sin(d));
            Console.WriteLine("El resultado de x es: " + x);
        }
    }
}
