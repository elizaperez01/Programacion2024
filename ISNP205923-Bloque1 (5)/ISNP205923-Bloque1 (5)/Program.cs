using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP205923_Bloque1__5_
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int suma = 0;
            int cantidadNumeros = 0;

            Console.WriteLine("******************************************");
            Console.WriteLine("*  Bienvenido al Programa de Promedios   *");
            Console.WriteLine("******************************************");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)

            {
                Console.Write("Ingresa un número o 0 para salir: ");
                Console.WriteLine();
          
                    bool esNumeroValido = int.TryParse(Console.ReadLine(), out numero);

                if (!esNumeroValido)
                {
                    Console.WriteLine("¡Entrada no válida! Por favor, ingresa otro número.");
                   
                }
                else
                {
                    suma += numero;
                    cantidadNumeros++;
                }

            }

            if (cantidadNumeros > 0)
            {
                double promedio = (double)suma / cantidadNumeros;
                Console.WriteLine();
                Console.WriteLine("******************************************");
                Console.WriteLine($"* El promedio de los {cantidadNumeros} números es: {promedio:F2}  *");
                Console.WriteLine("******************************************");
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("* No se ingresaron números válidos *");

            }

            Console.WriteLine();
            Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
            Console.WriteLine("*******************************************");

            Console.ReadKey(); // calcula el promedio y luego cierra
        }
    }
}


