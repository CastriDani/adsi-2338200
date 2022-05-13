using System;
using System.Collections.Generic;
using System.Text;

namespace Do_While
{
    internal class Ejercicio05
    {
        static void MainTEM(string[] args)
        {
            //Calcular la suma siguiente:100 + 98 + 96 + 94 + . . . + 0 en este orden

            int x = 100, suma = 0;

            do
            {
                suma = suma + x;
                x = x - 2;

            } while (x != 0);

            Console.WriteLine("La suma de los numeros es: " + suma);

        }



    }
}
