namespace _2_Edad_Y_Votacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- Edad y votación: Crea un programa que verifique si la edad ingresada por el usuario lo califica para votar (mayor o igual a 18 años). */

            Console.WriteLine("Hola, para poder votar primero debemos verificar tu edad: "); 
            Console.WriteLine("Por favor ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Excelente, tienes edad suficiente para poder votar. ");
            }
            else
            {
                Console.WriteLine("Lo siento, no tiene la edad suficiente para poder votar. ");
            }
        }
    }
}
