/*1.: Crear un programa que use el operador condicional para mostrar el valor absoluto de un numero de la siguiente forma:
  si el numero es positivo, se mostrara tal cual; si es negativo, se mostrara el signo cambiado*/
using System;

namespace Ejercicio_Con_plus
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Programa para mostrar el valor absoluto de un numero");
            Console.Write("Digite el numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            

            if (num < 0)
            {
                num = num * -1;
            }


            Console.Write($"El valor absoluto del numero {num} es: ");
            Console.Write(" "+num);
            Console.Write($" y -{num}");
;        }
    }
}
