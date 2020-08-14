using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosDificil
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, vidas = 3, condados = 0, total = 0, condadtres = 0, dado2 = 0;
            string continuar = "s";

            Console.Write("Desea empezar (s/n): ");
            continuar = Console.ReadLine();

            while (continuar == "s")
            {
                condadtres++;
                if (condadtres == 3)
                {
                    dado2 = aleatorio.Next(1, 7);
                    Console.Write("Dado = " + dado2);
                    total += dado2;
                    condadtres = 0;
                }
                dado = aleatorio.Next(1, 7);
                Console.Write(" Dado = " + dado);
                total += dado;
                condados++;

                if (condados == 2)
                {
                    vidas--;
                    Console.Write(" Vidas = " + vidas);
                    condados = 0;

                }
                if (dado == dado2)
                {
                    vidas++;                                
                    Console.Write(" Vidas = " + vidas);
                    dado2 = 0;
   
                }

                if (vidas == 0)
                {
                    Console.WriteLine(" Perdiste");
                    break;
                }
                if (total >= 100)
                {
                    Console.WriteLine(" Ganaste!");
                    break;
                }
                else
                {
                    Console.WriteLine(" Total = " + total);
                    Console.WriteLine(" Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                }

            }
        }
    }
}
