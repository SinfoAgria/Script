using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, n = 100;
            double sinx = 0, x = 0, d = 0;

            Console.WriteLine("Por favor, ingrese el número: ");
            x = double.Parse(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                d = (2 * i) + 1;
                double resultado = Factorial(d);

                sinx += (Math.Pow(-1, i) / resultado) * (Math.Pow(x, d));
                Console.WriteLine("Sin(x)= " + sinx);
            }
        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }    
}
