using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_For
{
    class Ejercicio02
    {
        static void Maint(string[] args)
        {

            /* Leer 10 números e imprimir solamente los números positivos */
            double num;

            for (int i = 1; i <= 99; i++)
            {
                Console.WriteLine("\ningrese un numero");

                num = double.Parse(Console.ReadLine());
                if (num > 0)

                {
                    Console.WriteLine("este numero es positivo " + num);
                }
                else
                {
                    Console.WriteLine("este numero no es positivo");
                }

            }
        }

    }
}
