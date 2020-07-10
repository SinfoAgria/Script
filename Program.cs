using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 90;

            Console.WriteLine("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            double t = (Math.Sqrt((y * y) + (z * z)));

            Console.WriteLine("Resultado de t= " + t);

            double sinC = (z / t);
            double c = Math.Asin(sinC);
            double cGrados = c * (180.0 / Math.PI);
            Console.WriteLine("Ángulo c= " + cGrados);

            double a = (180 - cGrados - b);
            Console.WriteLine("Angulo a= " + a);

            Console.WriteLine("Ángulo b= " + b);
        }
    }
}
