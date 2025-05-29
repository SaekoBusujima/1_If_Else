namespace _10_Clasificación_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- Crea un programa que, dado un número de temperatura, clasifique si está fría, cálida o caliente dependiendo del rango. */

            Console.WriteLine("Ingrese la temperatura de hoy, con numeros: ");
            string? entrada = Console.ReadLine();
            double temperatura;

            if (double.TryParse(entrada, out temperatura))
            {
                if(temperatura == 0 || temperatura < 20)
                {
                    Console.WriteLine("La temperatura " + temperatura + " es fria.");
                }
                else if (temperatura >= 20 && temperatura < 37)
                {
                    Console.WriteLine("La temperatura " + temperatura + " es calida.");
                }
                else if (temperatura >= 37 || temperatura < 50)
                {
                    Console.WriteLine("La temperatura " + temperatura + " es caliente.");
                }
            }
            else
            {
                Console.WriteLine("Solo se admiten numeros. ");
            }
        }
    }
}
