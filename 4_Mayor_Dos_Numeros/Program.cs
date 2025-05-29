namespace _4_Mayor_Dos_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- Mayor de dos números: Escribe un programa que reciba dos números y muestre cuál es mayor, o si son iguales. */

            Console.WriteLine("Ingrese el primer numero: ");
            string? entrada = Console.ReadLine();
            int numero1 = 0;

            Console.WriteLine("Ingrese el segundo numero: ");
            string? entrada2 = Console.ReadLine();
            int numero2 = 0;

            if (int.TryParse(entrada, out numero1) && int.TryParse(entrada2, out numero2))
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("El numero "+ numero1 + " es mayor que "+numero2);
                }
                else if(numero2 > numero1)
                {
                    Console.WriteLine("El numero "+ numero2 + " es mayor que "+numero1);
                }
                else if (numero1 == numero2)
                {
                    Console.WriteLine("Ambos numeros son iguales. ");
                }
            }
            else
            {
                Console.WriteLine("Los numeros ingresados no son enteros. ");
            }
        }
    }
}
