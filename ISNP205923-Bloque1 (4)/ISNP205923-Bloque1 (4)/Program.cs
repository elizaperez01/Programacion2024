using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP205923_Bloque1__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Program p = new Program();
                int numero;

                Console.WriteLine("************************************************");
                Console.WriteLine("*  Bienvenido al Programa de Números Primos    *");
                Console.WriteLine("************************************************");
                Console.WriteLine();

                do
                {
                    Console.Write("Ingresa un número (0 para salir): ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == 0) // Condición de salida
                    {
                        Console.WriteLine("Programa terminado.");
                        break; // Para salir del ciclo si el número es 0
                    }

                    if (numero <= 1)
                    {
                        Console.WriteLine($"{numero} no es un número primo.");
                    }
                    else
                    {
                        bool esPrimo = true;

                        for (int i = 2; i <= Math.Sqrt(numero); i++)
                        {
                            if (numero % i == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }

                        if (esPrimo)
                        {
                            Console.WriteLine($"{numero} es un número primo.");
                        }
                        else
                        {
                            Console.WriteLine($"{numero} no es un número primo.");
                        }
                    }

                    Console.WriteLine(); // linea en blanco

                } while (numero != 0);

                Console.WriteLine("Presiona cualquier tecla para salir...");
                Console.ReadKey(); //finalizar el programa
            }
        }

    }
}
