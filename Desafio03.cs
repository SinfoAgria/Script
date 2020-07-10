using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de c= ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de z= ");
            double z = double.Parse(Console.ReadLine());

            double a = (180 - c - 90);
            Console.WriteLine("El valor de a es= " + a);

            double cRad = c * (Math.PI / 180);
            double t = ((1/Math.Sin(cRad)) * z);
            Console.WriteLine("El valor de t es= " + t);

            double casiY = (t * t) - (z * z);
            double y = Math.Sqrt(casiY);
            Console.WriteLine("El valor de y es= " + y);

        }
    }
}
