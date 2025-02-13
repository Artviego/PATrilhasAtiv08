using System;
using System.Data.SqlTypes;

namespace a
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            string input = Console.ReadLine();

            // Converte a entrada para ser obrigatoriamente um inteiro
            int numero;
            if (int.TryParse(input, out numero))
            {
                Console.WriteLine($"\nO quadrado de {numero} é: {numAoQuadrado(numero)}"); // Exibe o quadrado do número
            }
            else
            {
                Console.WriteLine("Entrada inválida! Tente novamente.");
                Console.Clear();
            }
            Console.ReadKey(true);
        }

        // Metódo que retorna o quadrado do número
        public static int numAoQuadrado(int numero)
        {
            int quadrado = numero * numero;

            return quadrado;
        }
    }
}