using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP205923_Bloque1__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;
            Console.WriteLine("********************************");
            Console.WriteLine("*    Bienvenido al Programa    *");
            Console.WriteLine("********************************");
            Console.WriteLine();

            do
            {
                Console.Write("Ingresa un número positivo: ");
                Console.WriteLine();
                Console.WriteLine("Ingresa 0 o un número negativo para salir.");

                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    suma += num;
                    Console.WriteLine($"La suma actual es: {suma}");
                }
                Console.WriteLine();
            } while (num > 0);

        
        }

    }
   
}
