namespace _9_Descuento_por_edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que aplique un descuento en base a la edad del usuario. Por ejemplo, mayores de 60 obtienen un 30% de descuento, menores de 18 obtienen un 15%. */

            Console.WriteLine("Ingrese su edad en numeros para saber si aplica un descuento: ");
            int edad  = Convert.ToInt32(Console.ReadLine());

            if (edad >= 60)
            {
                Console.WriteLine("Tiene un descuento del 30% ");
                Console.WriteLine("Ingrese el precio del articulo: ");
                float precio = (float)Convert.ToDecimal(Console.ReadLine()); //Es necesario convertir explícitamente el tipo decimal a float

                float porcentaje = 30/100f;// Número flotante (float) Se coloca la f
                float descuento = precio * porcentaje;
                float total = precio - descuento;

                Console.WriteLine("Total a pagar: " + total + " aplicando un descuento del 30%");

            }
            else if (edad < 18)
            {
                Console.WriteLine("Tiene un descuento del 15% ");
                Console.WriteLine("Ingrese el precio del articulo: ");
                int precio = Convert.ToInt32(Console.ReadLine());

                float porcentaje = 15/100f;// Número flotante (float) Se coloca la f
                float descuento = precio * porcentaje;
                float total = precio - descuento;

                Console.WriteLine("Total a pagar: " + total + " aplicando un descuento del 15%");
            }
            else
            {
                Console.WriteLine("No se le puede aplicar un descuento. ");
            }
         }
    }
}
