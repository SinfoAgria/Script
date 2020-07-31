using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresExternos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string p = "p", pmax = "pm", pmin = "pi";

            while (i < n)
            {
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre de la persona: ");
                p = (Console.ReadLine());
                if (edad > max)
                {
                    max = edad;
                    pmax = p;
                }

                if (edad < min)
                {
                    min = edad;
                    pmin = p;
                }
                        
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + max + " Nombre: " + pmax);
            Console.WriteLine("Menor = " + min + " Nombre: " + pmin);
        }
    }
}
