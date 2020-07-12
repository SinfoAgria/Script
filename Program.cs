using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese d, b, y: ");
            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double e = (180 - dGrados - bGrados);
            double c = (180 - e);
            double a = (180 - c - 90);

            double aRad = a * (Math.PI / 180);

            double z = (y /Math.Tan (aRad));
            Console.WriteLine("El resultado de z es: " + z);

        }
    }
}
