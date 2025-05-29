namespace _3_NumeroPAR_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- Número par o impar: Diseña un programa que indique si un número dado es par o impar.*/

            Console.WriteLine("Ingresa un numero entero. ");
            string? entrada = Console.ReadLine();
            int numero = 0;

            if (int.TryParse(entrada, out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El numero es par: "+numero);
                }
                else
                {
                    Console.WriteLine("El numero es impar: " + numero);
                }
            }
            else
            {
                Console.WriteLine("No es un numero entero. ");
            }
        }
    }
}
