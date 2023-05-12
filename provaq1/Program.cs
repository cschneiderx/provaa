internal class Program
{
    private static void Main(string[] args)
    {
        string[] palavras = { "pedra", "cabelo", "macaco", "computador", "mouse", "rato", "cimento", "teclado" };
        Random random = new Random();
        string palavra = palavras[random.Next(palavras.Length)];
        string palavraemtraço = new string('_', palavra.Length);
        int chances = 6;
        while (chances > 0 && palavraemtraço.Contains('_'))
        {

            Console.WriteLine(palavraemtraço);
            Console.WriteLine("Tentativas restantes: " + chances);


            Console.Write("Digite uma letra: ");
            char letra = Console.ReadLine()[0];


            bool acertou = false;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    acertou = true;


                    palavraemtraço = palavraemtraço.Substring(0, i) + letra + palavraemtraço.Substring(i + 1);
                }
            }


            if (acertou)
            {
                Console.WriteLine("Acertou!");
            }
            else
            {
                Console.WriteLine("Errou!");
                chances--;
            }
        }

        if (chances == 0)
        {
            Console.WriteLine("Você perdeu! A palavra era: " + palavra);
        }
        else
        {
            Console.WriteLine("Parabéns, você ganhou! A palavra era: " + palavra);
        }
    }
}