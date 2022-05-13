using System;

namespace Ejercicios_While
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            static void Maint(string[] args)
            {
                /* . En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los 
                    estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo 
                    que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha 
                    tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los 
                    demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a 
                    obtener el total de sus compras */

                double precio, cantidad_de_articulos, total_a_pagar = 0, suma_de_producto = 0;

                string articulo = "", comprar;

                Console.WriteLine("desea comprar un articulo");
                comprar = Console.ReadLine();

                while (comprar == "si")
                {
                    Console.WriteLine("digite el nombre del articulo");
                    articulo = Console.ReadLine();
                    Console.WriteLine("digite la cantidada de articulo");
                    cantidad_de_articulos = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite el precio");
                    precio = double.Parse(Console.ReadLine());
                    total_a_pagar = precio * cantidad_de_articulos;
                    Console.WriteLine("desea comprar un articulo");
                    comprar = Console.ReadLine();
                    suma_de_producto = suma_de_producto + total_a_pagar;
                }

                Console.WriteLine("el total a pagar es " + suma_de_producto);
            }
        }
    }
}
