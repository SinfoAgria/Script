using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoNE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Tanjiro", "Nezuko", "Zinitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };

            for (int j = 0; j < estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;

                        string tmp2 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp2;
                    }
                }
            }

            for ( int i =0; i < estatura.Length; i++)
            {
                Console.WriteLine(nombres[i] + " " + estatura[i]);
            }
        }
    }
}
