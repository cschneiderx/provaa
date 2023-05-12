internal class Program
{
    private static void Main(string[] args)
    {
        string palavra = Console.ReadLine();
        char[] caracteres = palavra.ToCharArray();
        Array.Reverse(caracteres);
        string palavrainvertida = new string(caracteres);


        if (palavrainvertida == palavra)
        {
            Console.WriteLine("A palavra é um palindromo");
        }
        else
        {
            Console.WriteLine("A palavra não é  um palindromo");
        }
    }
}