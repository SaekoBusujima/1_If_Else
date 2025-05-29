namespace Numero_Negativo_Positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Número positivo o negativo*: Escribe un programa que determine si un número ingresado por el usuario es positivo, negativo o cero.*/

            Console.WriteLine("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo. ");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es 0 ");
            }
            
        }
    }
}
