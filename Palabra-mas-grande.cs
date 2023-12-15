/*
 * Dada una frase ingresada por teclado, encontrar la palabra mas grande si hay empate
 * devolver la primer concurrencia
 */
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una frase: ");
        string frase = Console.ReadLine();
        string[] frase_cortada = frase.Split(' ');
        List<int> taman = new List<int>();

        foreach(var palabras in frase_cortada)
        {
            taman.Add(palabras.Length);
        }

        int mayor = taman.Max();
        int indice = taman.IndexOf(mayor);
        string palabra_grande = frase_cortada[indice];

        Console.WriteLine("La palabra mas grande es {0}", palabra_grande);
        Console.ReadKey();


    }
}