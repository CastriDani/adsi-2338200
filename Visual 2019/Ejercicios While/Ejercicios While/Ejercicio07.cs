using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_While
{
    class Ejercicio07
    {
        static void Maint(string[] args)
        {
            //Encontrar el menor valor de un conjunto de n números dados.

            double x = 1, n, total, numero_menor = 0;
            Console.WriteLine("Escriba el total de numeros a calcular: ");
            _ = double.TryParse(Console.ReadLine(), out total);

            while (x <= total)
            {
                Console.WriteLine("Escriba un número: ");
                _ = double.TryParse(Console.ReadLine(), out n);

                if (x == 1)
                {
                    numero_menor = n;
                }
                else if (n < numero_menor)
                {
                    numero_menor = n;
                }
                x = x + 1;
            }

            Console.WriteLine("El número menor es " + numero_menor);
        }
    }
}
