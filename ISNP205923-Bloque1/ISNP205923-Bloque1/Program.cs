using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP205923_Bloque1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("******************************************");
            Console.WriteLine("*  Bienvenido al Programa de Números      *");
            Console.WriteLine("******************************************");
            Console.WriteLine();

            do
            {
                Console.Write("Por favor, ingresa un número (0 para salir): ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("¡El número es positivo!");
                }
                else if (number < 0)
                {
                    Console.WriteLine("El número es negativo :/");
                }
                Console.WriteLine(); // Linea en blaco


            } while (number != 0);
            Console.WriteLine("Programa terminado.");
        }
    }
}