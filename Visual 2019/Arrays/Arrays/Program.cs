namespace Arrays
{
    internal class Program
    {
        public static void Maint(string[] args)
        {
            Console.WriteLine("Arreglos/Arrays - Vectores");
            //declaracion/Deficnicion vector
            int[] numeros;

            //Inicializacion
            numeros = new int[5];

            //Asignaciones al vector
            numeros[2] = 6;
            numeros[4] = 20;

            Console.WriteLine("Numero en posicion 4: " + numeros[4]);
            Console.WriteLine("Numero en posicion 0: " + numeros[0]);
            numeros[4] = 35;
            Console.WriteLine("Numero en posicion 4: " + numeros[4]);

            //Recorremos el vector para asignar los datos

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero para la posicion" + i);
                int num = int.Parse(Console.ReadLine());
                numeros[i] = num;
            }

            //Recorremos el vector para mostrar los datos
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Valor en la posicion" + i + ":" + numeros[i]);
            }

            //Mostrar posicion especifica 
            Console.WriteLine("Que posicion desea ver");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor en la posicion" + pos + ":" + numeros[pos]);
        }
    }
}
