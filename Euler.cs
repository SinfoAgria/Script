using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, i = 0, n = 100;
            double e = 0;

            Console.WriteLine("Por favor, ingrese el número: ");
            x = int.Parse(Console.ReadLine());

            for(i = 0; i <= n; i++)
            {
                double resultado = Factorial(i);
               
                e  += Math.Pow(x, i) / resultado;
                Console.WriteLine("e= " + e);
            }           
        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
