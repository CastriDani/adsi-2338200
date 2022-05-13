using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_For
{
    class Ejercicio04
    {
        static void Maint(string[] args)
        {
            /* Suponga que se tiene un conjunto de calificaciones de un grupo de 40 alumnos. Realizar un algoritmo 
               para calcular la calificación promedio y la calificación más baja de todo el grupo. */
            double calificacion = 0, suma = 0, calificacion_promedio = 0, calificacion_baja;
            calificacion_baja = 99999;
            for (int i = 1; i <= 2; i++)
            {

                Console.WriteLine("digite la calificaion    " + i);
                calificacion = double.Parse(Console.ReadLine());
                //suma iterativa de las calificaciones
                suma = suma + calificacion;
                //calculamos la menor calificacion
                if (calificacion < calificacion_baja)
                {
                    calificacion_baja = calificacion;
                }
            }
            calificacion_promedio = suma / 4;

            Console.WriteLine("la calififacion promedio es:" + calificacion_promedio);
            Console.WriteLine("la calificacion mas baja es:" + calificacion_baja);
        }

    }
}
