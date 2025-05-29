namespace _8__Identificar_vocales_y_consonantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Programa que determine si un carácter ingresado es una vocal o una consonante. */

            Console.WriteLine("Ingrese una letra. ");
            char? caracter = Convert.ToChar(Console.ReadLine());

            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                Console.WriteLine("Es una vocal: " + caracter);
            }
            else
            {
                Console.WriteLine("Es una consonante: " + caracter);
            }
        }
    }
}
