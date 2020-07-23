using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos del partido 1, partido 2, votos en blanco, votos nulos, número de población, porcentaje de la población que es mayor de edad: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int blancos = int.Parse(Console.ReadLine());
            int anulados = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            int tv = a + b + blancos + anulados;
            int an = (int) (0.3 * (a + b));
            int pme = (int)(n * (p / 100));
            int abs = pme - tv;


            if ( (anulados < an || (a+b) > blancos) && (abs < tv)){
                Console.WriteLine("Las votaciones fueron exitosas");

                if (a > b)
                {
                    Console.WriteLine("El ganador de las votaciones es el partido 1");
                }
                else Console.WriteLine("El ganador de las votaciones es el partido 2");
            }
            else
            {
                Console.WriteLine("Las votaciones deben ser realizadas nuevamente");
            }
        }
    }
}
