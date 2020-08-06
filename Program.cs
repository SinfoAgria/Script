using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, cont = 0, totaltiros = 0, dadosigua = 0;
            double porcentaje = 0;
            string continuar = "s";

            while(continuar == "s"  )
            {
                dado1 = aleatorio.Next(1, 7);
                Console.Write("Dado = " + dado1);
                dado2 = aleatorio.Next(1, 7);
                Console.Write(" Dado = " + dado2);
                total += dado1 + dado2;
                if (dado1 == dado2)
                {
                    dadosigua++;
                }
                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine(" Eliminado");
                    continuar = "n";
                }else if(total >= 100 || dadosigua == 3)
                {
                    Console.WriteLine(" Victoria");
                    continuar = "n";
                }
                else
                {                    
                    Console.WriteLine(" Total = " + total);
                    Console.Write("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                }
                
                if(dado1 + dado2 >= 6)
                {
                    cont++; 
                }
                totaltiros++;
            }
            porcentaje = ((double)cont / totaltiros)*100;
            Console.WriteLine("Porcentaje: " + porcentaje);
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("Gracias por participar");
        }
    }
}
