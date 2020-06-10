/*4.: Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra 
 numerica o una consonante. Tips: usar dato tipo "char".*/
using System;

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            char carac;
            string val;

            Console.WriteLine("Validador de teclado si es una vocal , cifra numerica o una consonante");

            Console.Write("Ingrese un caracter del teclado: ");
            carac = Convert.ToChar(Console.ReadLine());
            val = Convert.ToString(carac);
            val = val.ToLower();


            if (val == "1" || val == "2 " || val == "3" || val == "4" || val == "5" || val == "6" || val == "7" || val == "8" || val == "9" || val == "0")
            {
                Console.WriteLine("Es un valor numerico");
            }
            else if (val == "a" || val == "e " || val == "i" || val == "o" || val == "u" )
            {
                Console.WriteLine("Es una vocal");
            }
            else if (val == "{" || val == "} " || val == "." || val == ";" || val == ":" || val == "?" || val == "¿" || val == " ' " || val == " - " || val == "," || val == "!" || val == "(" || val == ")")
            {
                Console.WriteLine("Son simbolos");

            }
            else
            {
                Console.WriteLine("Son consonantes");
            }
        }
    }
}
