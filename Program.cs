using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0, cont = 0, jugadores = 1, n = 0, ganador = 0, mayor = 0;
            string continuar = "s";

            while (jugadores < 2 || jugadores > 5)
            {
                Console.WriteLine("Numero de jugadores (2-5): " );
                jugadores = int.Parse(Console.ReadLine());
            }
            while (jugadores > n)
            {
                n++;
                Console.WriteLine("Bienvenido jugador: " + n);
                continuar = "s";
                total = 0;
                while (continuar == "s" && total <= 21)
                {
                    while (cont < 2)
                    {
                        carta = aleatorio.Next(1, 10);
                        Console.WriteLine("Cartas = " + carta);
                        total += carta;
                        cont++;
                        Console.WriteLine("Total = " + total);
                    }
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();

                    if (cont == 2 && continuar == "s")
                    {
                        carta = aleatorio.Next(1, 10);
                        Console.WriteLine("Cartas = " + carta);
                        total += carta;
                        Console.WriteLine("Total = " + total);
                    }
                    if (total > 21)
                    {
                        Console.WriteLine("No puede continuar");                        
                    }
                    else if (total== 21)
                    {
                        Console.WriteLine("Ganaste");
                        ganador = n;
                    }
                    else if (total > mayor)
                    {
                        mayor = total;
                        ganador = n;
                    }
                }
                
            }

                Console.WriteLine("El ganador fue " + ganador + " Y su total fue: " + mayor);
                Console.WriteLine("Gracias por participar");
            
        }
    }
}
