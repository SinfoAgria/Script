using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceMasaCorporal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su altura y su peso: ");
            double altura = double.Parse(Console.ReadLine());
            double peso = double.Parse(Console.ReadLine());

            double iMC = peso / (altura*altura);


            if (iMC < 18.5)
            {
                Console.WriteLine("Peso inferior al normal");
            }
            else if (iMC >= 18.5 && iMC < 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (iMC >= 25 && iMC < 29)
            {
                Console.WriteLine("Peso superior al normal");
            }
            else
            {
                Console.WriteLine("Obesidad");
            }

            Console.WriteLine("Su peso es: " + iMC);
        }
    }
}
