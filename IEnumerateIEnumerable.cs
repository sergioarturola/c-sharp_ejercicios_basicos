using System;
using System.Collections.Generic;


 class Program
{
    public static void Main(string[] args)
    {

        //creando la siguiente coleccion
        List<string>datos = new List<string>();

        datos.Add("Dato uno");
        datos.Add("Dato dos");
        datos.Add("Dato tres");
        datos.Add("Dato cuatro");

        //Con IEnumerable solo podemos recorrer la "coleccion"
        IEnumerable<string>usandoEnumerable = (IEnumerable<string>)datos;

        Console.WriteLine("Recorriendo la lista con IEnumerable");
        foreach (var d in usandoEnumerable)
        {
            Console.WriteLine(d);
        }

        //Con IEnumerate tenemos la ventaja de tener mas metodos para la iteracion de una coleccion
        Console.WriteLine("Recorriendo la lista con IEnumerate");

        IEnumerator<string> usandoEnumerator = datos.GetEnumerator();//para convertir una lista en un IEnumerator
        while (usandoEnumerator.MoveNext())
        {
            Console.WriteLine(usandoEnumerator.Current);
        }

    }
}