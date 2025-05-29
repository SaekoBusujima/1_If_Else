namespace _7_Calculadora_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*- Escribe un programa que permita al usuario seleccionar una operación básica (+, -, *, /) y dos números. Usa if y else para realizar la operación elegida. */
            Console.WriteLine("Ingresa un numero para la operacion que deseas realizar. ");
            Console.WriteLine("Ingresa 1.- Para sumar ");
            Console.WriteLine("Ingresa 2.- Para restar ");
            Console.WriteLine("Ingresa 3.- Para multiplicar ");
            Console.WriteLine("Ingresa 4.- Para dividir ");
            int opcion = Convert.ToInt32(Console.ReadLine());


            if(opcion >= 1 && opcion <= 4)
            {
                Console.WriteLine("Ingrese el primer numero: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    int resultadoSuma = numero1 + numero2;
                    Console.WriteLine("El resultado de la suma es: " + resultadoSuma);
                }
                else if (opcion == 2)
                {
                    int resultadoResta = numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es: " + resultadoResta);
                }
                else if (opcion == 3)
                {
                    int resultadoMultiplicacion = numero1 * numero2;
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultadoMultiplicacion);
                }
                else if (opcion == 4)
                {
                    float resultadoDivision = numero1 / numero2;
                    Console.WriteLine("El resultado de la division es: " + resultadoDivision);
                }
            }
            else
            {
                Console.WriteLine("No hay una opcion para el numero ingresado: " +  opcion);
            }

        }
    }
}
