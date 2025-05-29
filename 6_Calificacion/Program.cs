namespace _6_Calificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- Crea un programa que reciba una calificación (de 0 a 100) e imprima si es Excelente, Bueno, Regular o Reprobado. */
            Console.WriteLine("Ingresa tu calificacion del 0 al 100 solo en numeros. ");
            string? entrada = Console.ReadLine();
            int calificacion;

            if (int.TryParse(entrada, out calificacion))
            {
                if (calificacion >= 0 && calificacion <= 25)
                {
                    Console.WriteLine("Tu calificacion es de reprobado: "+calificacion);
                }
                else if (calificacion > 25 && calificacion <= 49)
                {
                    Console.WriteLine("Tu calificacion es regular: "+ calificacion);
                }
                else if (calificacion >= 50 && calificacion <= 89)
                {
                    Console.WriteLine("Tu calificacion es buena: "+calificacion);
                }
                else if(calificacion >= 90 && calificacion <= 100)
                {
                    Console.WriteLine("Tu calificacion es excelente: "+calificacion);
                }
                else
                {
                    Console.WriteLine("Solo se aceptan la calificacion del 0 al 100");
                }
            }
            else
            {
                Console.WriteLine("la calificacion debe ser solo en numeros. ");
            }
        }
    }
}
