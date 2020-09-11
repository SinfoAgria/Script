using System;

namespace Matrices02
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            int m = 15;

            string[,] celdas = new string[n,m];

            for (int i = 0; i < celdas.GetLength(0); i++)
            {
                for (int j = 0; j < celdas.GetLength(1); j++)
                {
                    celdas[i, j] = "-";
                }
            }

            Console.WriteLine("Entrada: ");
            for (int i = 0; i < celdas.GetLength(0); i++)
            {
                for (int j = 0; j < celdas.GetLength(1); j++)
                {
                    Console.Write("|" + celdas[i, j]);
                }
                Console.Write("|\n");
            }

            Console.WriteLine("Ingrese la fila deseada: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna deseada: ");
            int y = int.Parse(Console.ReadLine());


            if (celdas[x - 1, y - 1] == "-")
            {
                celdas[x - 1, y - 1] = "X";
                Matriz(celdas);
            }

            else
            {
                Console.WriteLine("La posición seleccionada: " + "(" + x + "," + y + ")" + "se encuentra ocupada.");
                Console.WriteLine("Debe seleccionar otra posición.");
            }
        }

        static void Matriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("|" + matriz[i, j]);
                }

                Console.Write("|\n");

            }

        }
    }
}
