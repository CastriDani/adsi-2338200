using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Vector01
    {
        public static void Main(string[] args)
        {
            // Solicitar al usuario los nombres de N personas, almacenarlos en un vector
            // Mostrar los nombre almacenados y decir si en la lista de personas 
            // Se encuentra "Ana"

            string nombre_personas = "Ana";
            int num_personas;
            Console.WriteLine("Digite el numero de personas que desea ingresar");
            _ = int.TryParse(Console.ReadLine(), out num_personas);
            int[] arreglo;
            arreglo = new int[num_personas];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona " + i);
                nombre_personas = Console.ReadLine();

            }
            for (nombre_personas != "Ana")
            {
                
                Console.WriteLine("Se a encontrado el nombre de (Ana)");
                
            }

        }
    }
}
