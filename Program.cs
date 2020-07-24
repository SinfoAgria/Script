using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeContratoSwitch
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

            switch (contrato)
            {
                case 2:
                    Console.WriteLine("Ingrese el riesgo del 1 al 5: ");
                    riesgo = int.Parse(Console.ReadLine()); break;
            }

            baseCoti = (40 * SM) / 100;
            if (baseCoti < smin)
            {
                baseCoti = smin;
            }

            switch (contrato)
            {
                case 1: pension = (4 * baseCoti) / 100;
                    eps = (4 * baseCoti) / 100;
                    deduccion = (pension + eps); break;


                case 2:
                    pension = (16 * baseCoti) / 100;
                    eps = (12.5 * baseCoti) / 100;
                    deduccion = (pension + eps);
                    switch (riesgo) {
                        case 1: arl = ((0.522 * baseCoti) / 100); break;
                        case 2: arl = ((1.044 * baseCoti) / 100); break;
                        case 3: arl = ((2.436 * baseCoti) / 100); break;
                        case 4: arl = ((4.350 * baseCoti) / 100); break;
                        case 5: arl = ((6.960 * baseCoti) / 100); break;
                    }

                    deduccion = (eps + arl + pension); break;
            }

            srm = (SM - deduccion);
            Console.WriteLine("Tu salario real mensual es: " + srm);

            switch (contrato) { case 1:  sra = ((srm * 12) + SM);break;
                case 2: sra = srm * 12; break;
            }

            Console.WriteLine("Tu salario real anual es: " + sra);
        }
    }
}
