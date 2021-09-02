using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class Program
    {
        static void Main(string[] args)
        {	
			int cantidadEntre10y15=0, cantidadMenor7=0;
			int sumaGenerados=0;
			Random r = new Random();
            for (int contador = 1; contador <= 5; contador++)
            {
				var numeroGenerado = r.Next(1, 21);
                Console.WriteLine($"Nùmero generado={numeroGenerado}");
				sumaGenerados += numeroGenerado;
                if (numeroGenerado<7)
                {
					cantidadMenor7++;
                } else if (numeroGenerado>=10 && numeroGenerado<=15)
                {
					cantidadEntre10y15++;
                }
            }

            Console.WriteLine($"Se ingresaron {cantidadEntre10y15} nùmeros entre 10 y 15");
            Console.WriteLine($"Se ingresaron {cantidadMenor7} nùmeros menores a 7");
            Console.ReadLine();
		}
    }
}
