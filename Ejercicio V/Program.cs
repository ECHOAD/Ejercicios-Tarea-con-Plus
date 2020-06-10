//Crear un programa que escriba en pantalla los numeros pares del 23 al 7 en orden descendente, usando while.
using System;

namespace Ejercicio_V
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 27;
            Console.WriteLine("Programa que muestre en pantalla los numeros pares del 23 al 7 de forma descendente" );

            while (i > 7)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" Es par");

                }
                i--;
            }
            
        }
    }
}
