using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP205923_Bloque1__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int number;
            Console.WriteLine("******************************************");
            Console.WriteLine("*  Bienvenido al Mundo de Las Tablas de Multiplicar  *");
            Console.WriteLine("******************************************");
            Console.WriteLine();

            do
            {
                Console.Write("Ingresa un número entre 1 y 10 (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 1 && numero <= 10)
                {
                    Console.WriteLine($"Tabla de multiplicar del {numero}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
                else if (numero != 0)
                {
                    Console.WriteLine("Por favor, ingresa un número válido entre 1 y 10.");
                }

                Console.WriteLine(); // Linea en blanco

            } while (numero != 0);
        }
    }
}
