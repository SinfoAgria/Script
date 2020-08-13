using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int num1 = 0, num2 = 0, resultadosum = 0, resultado = 0, cont =0;
            Console.WriteLine("Bienvenido al programa!");
            num1 = aleatorio.Next(1, 101);
            Console.WriteLine("Numero uno: " + num1);
            num2 = aleatorio.Next(1, 101);
            Console.WriteLine("Numero uno: " + num2);
            resultadosum = num1 + num2;
            Console.WriteLine("Por favor, escriba el resultado de la suma: ");
            resultado = int.Parse(Console.ReadLine());

            while (resultado != resultadosum)
            {
                Console.WriteLine("Validación incorrecta");
                num1 = aleatorio.Next(1, 101);
                Console.WriteLine("Numero uno: " + num1);
                num2 = aleatorio.Next(1, 101);
                Console.WriteLine("Numero uno: " + num2);
                resultadosum = num1 + num2;
                Console.WriteLine("Por favor, escriba el resultado de la suma: ");
                resultado = int.Parse(Console.ReadLine());
                cont++;
                if (cont == 2)
                {
                    Console.WriteLine("Validación incorrecta no puede continuar");
                    break;
                }

                if(resultado ==resultadosum) Console.WriteLine("Puede continuar");
            }
        }
    }
}
