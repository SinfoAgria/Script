﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada del usuario de la variable X1
            Console.Write("Ingrese X1: ");
            double x1 = double.Parse(Console.ReadLine());

            // Entrada del usuario de la variable Y1
            Console.Write("Ingrese Y1: ");
            double y1 = double.Parse(Console.ReadLine());

            // Entrada del usuario de las variables restantes
            // ...
            Console.Write("Ingrese X2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double m = ((y2 - y1) / (x2 - x1));

            Console.WriteLine("Resultado de la pendiente= " + m);

            double b = (y1 - (m * x1));

            Console.WriteLine("Resultado del intercepto= " + b);

            double d = (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

            Console.WriteLine("Resultado de la distancia= " + d);
        }
    }
}
