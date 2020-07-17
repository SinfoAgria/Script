using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            double smin = 877803;
            double arl = 0;
            double eps = 0;
            double riesgo = 0;
            double baseCoti = 0;
            double pension = 0;
            double deduccion = 0;
            double srm = 0;
            double sra = 0;

            Console.WriteLine("Ingrese su salario mensual: ");
            double SM = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato: (1)Dependiente, (2)Independiente: ");
            int contrato = int.Parse(Console.ReadLine());
            
            if (contrato == 2)
            {
                Console.WriteLine("Ingrese el riesgo del 1 al 5: ");
                riesgo = int.Parse(Console.ReadLine());
            }

            baseCoti = (40 * SM) / 100;
            if (baseCoti < smin)
            {
                baseCoti = smin;
            }

            if (contrato == 1)
            {
                pension = (4 * baseCoti) / 100;
                eps = (4 * baseCoti) / 100;
                deduccion = (pension + eps);
            }
            else
            {
                pension = (16 * baseCoti) / 100;
                eps = (12.5 * baseCoti) / 100;
                deduccion = (pension + eps);
                if (riesgo == 1) arl = ((0.522 * baseCoti )/ 100);
                else if (riesgo == 2) arl = ((1.044 * baseCoti) / 100);
                else if (riesgo == 3) arl = ((2.436 * baseCoti) / 100);
                else if (riesgo == 4) arl = ((4.350 * baseCoti) / 100);
                else arl = ((6.960 * baseCoti) / 100);

                deduccion = (eps + arl + pension);
            }

            srm = (SM - deduccion);
            Console.WriteLine("Tu salario real mensual es: " + srm);

            if (contrato == 1) sra = ((srm*12)+SM); 
            else  sra = srm*12; 

            Console.WriteLine("Tu salario real anual es: " + sra);

        }
    }
}
