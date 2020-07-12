using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w, d, x: ");
            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double drad = dGrados * (Math.PI / 180);

            double t = (Math.Sqrt((w * w) + (x * x) - 2 * w * x * Math.Cos(drad)));

            double casiE = ((w * w) - (x * x) - (t * t)) / (-2 * x * t);
            double e = Math.Acos(casiE);
            double eGrados = e * (180.0 / Math.PI);

            double c = (180 - eGrados);
            double a = (180 - c - 90);

            double crad = c * (Math.PI / 180);
            double z = (Math.Sin(crad) * t);

            double y = Math.Sqrt((t * t) - (z * z));
            Console.WriteLine("Resultado de y: " + y);
        }
    }
}
