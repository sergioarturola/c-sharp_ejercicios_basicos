using System;
/*
 * Sin usar metodos y solamente bucles invierta el contenido de un string, 
 * pida la cadena por teclado
 */
namespace Invertir_palabra_sin_metodos
{
    class InvertirPalabra
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe la cadena a invertir: ");
            string cadena = Console.ReadLine();
            string inverso = "";

            foreach(var letra in cadena)
            {
                 inverso = letra + inverso;
            }

            Console.WriteLine(inverso);

        }
    }
}
