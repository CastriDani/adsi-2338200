using System;
using System.Collections.Generic;
using System.Text;

namespace Do_While
{
    class Ejercicio_Supermercado
    {
        static void Maint(string[] args)
        {


            /*En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los
             estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo
          que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha
           tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los
           demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a
             obtener el total de sus compras.*/


            char opcion;
            int total_articulos = 0;
            do
            {
                Console.WriteLine("Ingrese el nombre del articulo");
                string nomb_articulo = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad del articulo");
                _ = int.TryParse(Console.ReadLine(), out int cantidad);
                Console.WriteLine("Ingrese el valor del articulo");
                _ = int.TryParse(Console.ReadLine(), out int valor);
                int precio_total_articulo = valor * cantidad;
                Console.WriteLine("El total del articulo" + nomb_articulo + "es: " + precio_total_articulo);
                total_articulos += precio_total_articulo;


                Console.WriteLine("Desea ingresar mas articulos si (S) | no (N)");
                _ = char.TryParse(Console.ReadLine(), out opcion);

            }while (opcion == 'S');

            Console.WriteLine("El total de la compra va ser de : " + total_articulos);





        }

    }
}
