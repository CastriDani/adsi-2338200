using System;

namespace Ejercicio_For
{
    class Ejercicio01
    {
        static void Maint(string[] args)
        {
            /* Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Diseño Estructurado 
               de Algoritmos.
            */

            double notas, promedio = 0, cantidad_de_notas;
            Console.WriteLine("cantidad de notas que desea ingresar ");
            _ = double.TryParse(Console.ReadLine(), out cantidad_de_notas);

            for (int i = 0; i < cantidad_de_notas; i++)
            {
                Console.WriteLine("ingese su nota");

                notas = double.Parse(Console.ReadLine());
                promedio += notas / cantidad_de_notas;

            }
            Console.WriteLine("su promedio es: " + promedio);


        }

    }
}

