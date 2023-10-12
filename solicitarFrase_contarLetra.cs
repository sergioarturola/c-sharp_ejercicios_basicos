public class Program
    /*
     * Crear un programa en C# a prueba de errores que permita ingresar una frase
     * y despues solicite la letra a contabilizar, despues preguntar si se desea
     * ingresar otra frase o terminar el programa
     */
{
    private static void Main(string[] args)
    {
        bool solicitarFrase = true;

        while(solicitarFrase)
        {

            try
            {
                Console.WriteLine("Ingresa una frase: ");
                string frase = Console.ReadLine();
                Console.WriteLine("Ingresa vocal a contar");
                char letra = Console.ReadLine()[0];
                int contador_letra = 0;

                if (frase.Contains(letra))
                {
                    foreach(char c in frase)
                    {
                        if(c == letra) contador_letra++;
                    }

                    Console.WriteLine("La letra {0} se repite {1} veces", letra, contador_letra);
                }
                else
                {
                    Console.WriteLine("La letra no se encuentra en la frase");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Formato invalido, vuelve a intentarlo");
            }
            finally
            {
                Console.WriteLine("Ingresar otra frase? (s/n)");
                char resp = Console.ReadLine()[0];

                if(resp == 'n') solicitarFrase=false;

            }
        }

    }
}