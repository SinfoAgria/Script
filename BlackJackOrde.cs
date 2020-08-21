using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackordenado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0, cont = 0, jugadores = 1, n = 0, ganador = 0, mayor = 0, punt = 0;
            string continuar = "s", nompun = "";

            while (jugadores < 2 || jugadores > 5)
            {
                Console.WriteLine("Numero de jugadores (2-5): ");
                jugadores = int.Parse(Console.ReadLine());
            }

            string[] nombres = new string[jugadores];
            int[] puntajes = new int[jugadores];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Nombre del jugador: ");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++)                       
            {                      
                continuar = "s";
                total = 0;
                Console.WriteLine("Bienvenido jugador " + nombres[i]);

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
                        total = 0;
                        break;
                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("Ganaste");
                        ganador = n;
                        break;
                    }                                    
                }
                puntajes[i] = total;
                if (puntajes[i] > punt)
                {
                    punt = puntajes[i];
                    nompun = nombres[i];
                }
                Console.WriteLine("Jugador: " + nombres[i] + " Puntaje: " + puntajes[i]);
            }
            Console.WriteLine("El ganador fue " + nompun + " Y su total fue: " + punt);
            Console.WriteLine("El segundo puesto fue " + nombres[1] + " Y su total fue: " + puntajes[1]);
            Console.WriteLine("Gracias por participar");
        }
    }
}
