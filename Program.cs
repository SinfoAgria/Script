using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosAcumulando
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, vidas = 3, dadosuno = 0, dadoespe = 0, dadoconesp = 0, dadosseis = 0;
            string continuar = "s", e = "";

            Console.WriteLine("Desea empezar (s/n): ");
            continuar = Console.ReadLine();
            while (continuar == "s")
            {
                if (dadoconesp < 2)
                {
                    Console.WriteLine("¿Usar dado especial? (e): ");
                    e = Console.ReadLine();
                }

                if (e == "e" && dadoconesp < 2)
                {
                 dadoespe = aleatorio.Next(1, 13);
                 Console.Write("Dado especial: " + dadoespe);
                 dadoconesp++;
                 total += dadoespe;
                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                    Console.Write("Dado = " + dado);
                    total += dado;
                }

                if (dado == 1 || dadoespe == 1)
                {
                    dadosuno++;

                }
                if(dadosuno == 2 )
                {
                    vidas -= 1;
                    Console.WriteLine(" 1 Vida menos: " + vidas);
                    
                    if (total < 10)
                    {
                        total = 0;
                    }
                    else
                    {
                        total = total - 10;
                    }
                    dadosuno = 0;
                }
                if (total >= 100)
                {
                    Console.WriteLine(" Total = " + total);
                    Console.WriteLine(" Ganaste!");
                    break;
                }
                if (vidas == 0)
                {
                    Console.WriteLine("Perdiste");
                    break;
                }
                if (dado == 6 || dadoespe == 6)
                {
                    dadosseis++;
                }else if (dado !=6 || dadoespe != 6)
                {
                    dadosseis = 0;
                }
                if (dadosseis == 2)
                {
                    if (vidas == 3)
                    {
                        Console.WriteLine(" Vidas: " + vidas);
                        vidas = 3;
                    }
                    else
                    {
                        vidas++;
                        Console.WriteLine(" Vidas: " + vidas);                        
                    }
                    Console.WriteLine(" Total = " + total);
                    Console.WriteLine(" Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
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
