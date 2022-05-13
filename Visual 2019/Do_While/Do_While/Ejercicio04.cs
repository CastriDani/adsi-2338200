using System;
using System.Collections.Generic;
using System.Text;

namespace Do_While
{
    internal class Ejercicio04
    {
        static void MainTEM(string[] args)
        {
            /*Un censador recopila ciertos datos aplicando encuestas para el último Censo Nacional de Población
            y Vivienda. Desea obtener de todas las personas que alcance a encuestar en un día, que porcentaje
            tiene estudios de primaria, secundaria, carrera técnica, estudios profesionales y estudios de
            posgrado.
            El programa debe preguntar si se desea continuar ingresando datos.*/

            int a = 0, b = 0, c = 0, d = 0, e = 0, total = 0, x, n;
            double porcentajeprimaria, porcentajesecundaria, porcentajetecnico, porcentajeprofesional, porcentajeposgrado;

            do
            {
                Console.WriteLine("Digite el numero segun corresponda su nivel de estudio:");
                Console.WriteLine("     1   =   Primaria");
                Console.WriteLine("     2   =   Secundaria");
                Console.WriteLine("     3   =   Carrera técnica");
                Console.WriteLine("     4   =   Estudios profesionales");
                Console.WriteLine("     5   =   Estudios posgrados");
                _ = int.TryParse(Console.ReadLine(), out n);

                if (n >= 1 && n <= 5)
                {
                    if (n == 1)
                    {
                        a = a + 1;
                    }
                    else if (n == 2)
                    {
                        b = b + 1;
                    }
                    if (n == 3)
                    {
                        c = c + 1;
                    }
                    else if (n == 4)
                    {
                        d = d + 1;
                    }
                    if (n == 5)
                    {
                        e = e + 1;
                    }
                    total = total + 1;
                    Console.WriteLine("El total: " + total);

                }
                else
                {
                    Console.WriteLine("Escriba un valor valido ");
                }
                Console.WriteLine("Desea continuar con la encuesta?");
                Console.WriteLine("     1   =   Continuar con la encuesta");
                Console.WriteLine("     Escriba otro numero para finalizar la encuesta");
                _ = int.TryParse(Console.ReadLine(), out x);

            } while (x == 1);

            porcentajeprimaria = (double)a / total * 100;
            porcentajesecundaria = (double)b / total * 100;
            porcentajetecnico = (double)c / total * 100;
            porcentajeprofesional = (double)d / total * 100;
            porcentajeposgrado = (double)e / total * 100;

            Console.WriteLine("El " + porcentajeprimaria + "% tiene primaria");
            Console.WriteLine("El " + porcentajesecundaria + "% tiene secundaria");
            Console.WriteLine("El " + porcentajetecnico + "% tiene carrera tecnica");
            Console.WriteLine("El " + porcentajeprofesional + "% tiene carrera profesional");
            Console.WriteLine("El " + porcentajeposgrado + "% tiene posgrado");

        }
    }
}
