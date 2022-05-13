using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_For
{
    class Ejercicio03
    {
        static void Maint(string[] args)
        {
            /* Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos cero. */

            double num = 0;
            int contador_cero = 0, contador_positivo = 0, contador_negativo = 0;

            for (int i = 0; i <= 4; i++)

            {
                Console.WriteLine("ingrese los numeros");

                num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    contador_negativo = contador_negativo + 1;
                }
                if (num > 0)

                {
                    contador_positivo = contador_positivo + 1;
                }
                if (num == 0)
                {
                    contador_cero = contador_cero + 1;
                }
            }
            Console.WriteLine("la cantidad de numeros negativos es " + contador_negativo);
            Console.WriteLine("la cantidad de numeros positivos son " + contador_positivo);
            Console.WriteLine("este es el numero cero " + contador_cero);
        }

    }
}
