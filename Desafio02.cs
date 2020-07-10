using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de t= ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de a= ");
            double a = double.Parse(Console.ReadLine());

            double c = (180 - a - 90);
            Console.WriteLine("El valor de c es= " + c);

            double rad = a * (Math.PI / 180);
            double y = (Math.Sin(rad) * t);
            Console.WriteLine("El valor de y es= " + y);

            double casiZ = (t * t) - (y * y);
            double z = Math.Sqrt(casiZ);
            Console.WriteLine("El valor de z es= " + z);
        }
    }
}
