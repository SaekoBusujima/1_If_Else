namespace _1_Ejercicios_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingresa un número:");
            string? entrada = Console.ReadLine();
            int numero;

            // Validar que la entrada sea un número válido
            if (int.TryParse(entrada, out numero))
            {
                // Verificar si el número es positivo, negativo o cero
                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }

        }
    }
}
