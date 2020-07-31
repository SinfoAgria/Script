using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0, cont = 0;
            string continuar = "s";
            
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
            }Console.WriteLine("Su total fue " + total);
            Console.WriteLine("Gracias por participar");
        }
    }
}
