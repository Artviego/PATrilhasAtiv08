using System;

namespace b
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            Console.WriteLine("A quantidade de caractéres na palavra é: {0}", quantCaracteres(palavra));

            Console.ReadKey(true);
        }

        public static int quantCaracteres (string palavra)
        {
            if (palavra == null)
            {
                return 0;
            }

            // Retorna o número de caractéres na string
            return palavra.Length;
           
        }
    }
}