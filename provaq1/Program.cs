internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = { 1, 24, 43, 74, 15, 6, 17, 83, 79, 52, 15 };
        bool mudou;

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        do
        {
            mudou = false;
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                if (numeros[i] > numeros[i + 1])
                {
                    int maior = numeros[i];
                    numeros[i] = numeros[i + 1];
                    numeros[i + 1] = maior;
                    mudou = true;

                }

            }
        } while (mudou);
        Console.WriteLine("\nem ordem\n");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}