using System;
using System.Collections.Generic;
using System.Text;

namespace Do_While
{
    class Ejercicio_Contraseña
    {
        static void Maint(string[] args)
        {

            //Realizar un algoritmo que nos permita solicitar una clave numerica al usuario y no
            //permitir continuar hasta que no ingrese la clave valida

            double contraseña = 1234, intentos=3;
            
            do
            {

                Console.WriteLine("Digite La Contraseña Para Ingresar \n");
                _ = double.TryParse(Console.ReadLine(), out contraseña);
                    if(contraseña != 1234)
                    {
                        Console.WriteLine("Contraseña Incorrecta, Ingresela De Nuevo");
                    }
                    else
                    {
                        intentos--;
                        Console.WriteLine("La Contraseña es Incorrecta");
                        if (intentos == 0);
                        {
                        Console.WriteLine("Supero los intentos posibles, se a bloqueado al contraseña");
                        }
                    
                    }

            }while (contraseña != 1234 && intentos > 0);
            
            Console.WriteLine("Contraseña Correcta");
        }
    }
}
