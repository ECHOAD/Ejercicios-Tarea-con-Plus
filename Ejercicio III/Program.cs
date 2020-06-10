/*3.: Crear un programa que lea una letra tecleada por el usuario y diga  
si se trata de un signo de puntuacion, una cifra numerica o algun otro caracter.*/

using System;
using System.IO;

namespace Ejercicio_III
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char carac;
                string val;
                Console.WriteLine("Programa para verificar lo que usuario digite");

                Console.Write("Ingrese un caracter del teclado: ");
                carac = Convert.ToChar(Console.ReadLine());
                val = Convert.ToString(carac);



                if (val == "1" || val == "2 " || val == "3" || val == "4" || val == "5" || val == "6" || val == "7" || val == "8" || val == "9" || val == "0")
                {
                    Console.WriteLine("Es un valor numerico");
                }

                else if (val == "{" || val == "} " || val == "." || val == ";" || val == ":" || val == "?" || val == "¿" || val == " ' " || val == " - " || val == "," || val == "!" || val == "(" || val == ")")
                {

                }
                else if (val == " ")
                {
                    Console.WriteLine("No digito nada ,es un espacio");
                }
                else
                {
                    Console.WriteLine("Es una letra");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);

            }
            
            

            
        }
    }
}
