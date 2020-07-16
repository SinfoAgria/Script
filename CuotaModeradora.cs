using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuotaModeradora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor escriba la cantidad de SMMLV que gana: ");
            int smmlv = int.Parse(Console.ReadLine());

            double sb = 877803;

            if (smmlv < sb * 2)
            {
                Console.WriteLine("Tarifa A y su Cuota moderadora es 3.400");
            }
            else if (smmlv >= sb * 2 && smmlv < sb * 5)
            {
                Console.WriteLine("Tarifa B y su Cuota moderadora es 13.500");
            }
            else
            {
                Console.WriteLine("Tarifa C y su Cuota moderadora es 35.600");
            }
        }
    }
}
