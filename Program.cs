using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoTarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor escriba la cantidad de SMMLV que gana: ");
            int smmlv = int.Parse(Console.ReadLine());

            double sb = 877803;

            if (smmlv < sb*2)
            {
                Console.WriteLine("Tarifa A");
            }
            else if (smmlv >= sb*2 && smmlv < sb*4)
            {
                Console.WriteLine("Tarifa B");
            }
            else {
                Console.WriteLine("Tarifa C");
            }
        }
    }
}
