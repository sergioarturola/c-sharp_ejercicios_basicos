using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//crear un programa que primero verifique que sea un numero de cuatro cifras
//y despues muestre por pantalla el numero en cada una de sus unidades en letras
//si se ingresa 1509 la salida es uno cinco cero nueve
namespace IngresarNumerosPonerLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numeros = new Dictionary<int, string>()
            {
                {0, "cero"},
                {1, "uno"},
                {2, "dos"},
                {3, "tres"},
                {4, "cuatro"},
                {5, "cinco"},
                {6, "seis"},
                {7, "siete"},
                {8, "ocho"},
                {9, "nueve"}
            };

            int milesima, centena, decena, unidad;
            Console.Write("Digita un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (Verificar(numero))
            {
                milesima = numero / 1000;
                numero = numero % 1000; //recogiendo el residuo de numero
                centena = numero / 100;
                numero = numero % 100;
                decena = numero / 10;
                unidad = numero % 10;

                Imprimir(numeros, milesima, centena, decena, unidad);

            }
            else
            {
                Console.WriteLine("No puedo realizar operaciones");
            }
        }

        static bool Verificar(int x)
        {
            int contador = 0;

            while (x > 0)
            {
                x = x / 10;
                contador++;
            }

            if(contador == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Imprimir(Dictionary<int, string> num, int a, int b, int c, int d)
        {
            Console.WriteLine(num[a] +"-"+num[b]+"-"+ num[c]+"-"+ num[d]);
        
        }
    }
}
