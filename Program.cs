using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Tanjiro", "Nezuko", "Zinitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };

            double suma = 0;

            for (int i = 0; i < estatura.Length; i++)
            {
                suma += estatura[i];
            }

            double promedio = suma / estatura.Length;
            Console.WriteLine("Promedio: " + promedio);

            double[] distancia = new double[estatura.Length];
            double min = 200;
            string dismen="";

            for (int i = 0; i < estatura.Length; i++)
            {
                distancia[i] = Math.Abs (promedio - estatura[i]);
                Console.WriteLine("Distancias: " + distancia[i]);

                if (distancia[i] < min)
                {
                    min = distancia[i];
                    dismen = nombres[i];
                }
            }

            Console.WriteLine("Nombre: " + dismen);

        }
    }
}
