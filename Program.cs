using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte un dato en binario: ");
            int b0 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte un dato en binario: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte un dato en binario: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte un dato en binario: ");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte un dato en binario: ");
            int b4 = int.Parse(Console.ReadLine());

            double resultado = (b0 * 16) + (b1 * 8) + (b2 * 4) + (b3 * 2) + (b4 * 1);
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
