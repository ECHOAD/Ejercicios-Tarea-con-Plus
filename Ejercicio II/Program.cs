// Usar el operador condicional para calcular el menor de dos numeros.
using System;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Programa para verificar cual es el menor de dos numeros");

            Console.Write("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 < num2)
            {
                Console.WriteLine("El numero menor es " + num1);
            }
            else
            {
                Console.WriteLine("El numero menor es " + num2);
            }
        }
    }
}
