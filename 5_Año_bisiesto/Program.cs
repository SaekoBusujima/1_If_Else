namespace _5_Año_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Programa que determine si un año ingresado por el usuario es bisiesto.
             *(Un año es bisiesto si es divisible por 4, pero no por 100, excepto si también es divisible por 400).*/

            Console.WriteLine("Ingrese el año en numeros para saber si es bisiesto. ");
            string? entrada = Console.ReadLine();
            int year;

            if (int.TryParse(entrada, out year))
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("El año es bisiesto. "+ year);
                }
                else if(year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine("El año es bisiesto. "+year);
                }
                else
                {
                    Console.WriteLine("El año no es bisiento. "+year);
                }
            }
            else
            {
                Console.WriteLine("No se admiten otros caracteres mas que numeros. ");
            }
        }
    }
}
