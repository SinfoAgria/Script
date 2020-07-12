using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w, t, c: ");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cgrados = double.Parse(Console.ReadLine());

            double a = (180 - 90 - cgrados);

            double cRad = cgrados * (Math.PI / 180);

            double sinC = Math.Sin(cRad);
            double z = sinC * t;

            double y = Math.Sqrt((t * t) - (z * z));

            double j = Math.Sqrt((w * w) - (z * z));

            double x = j - y;
            Console.WriteLine("Resultado: " + x);
        }
    }
}
