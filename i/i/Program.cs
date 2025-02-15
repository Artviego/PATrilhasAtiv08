using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite um número inteiro para verificar se é primo: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            bool resultado = VerificarPrimo(numero);

            if (resultado)
            {
                Console.WriteLine($"\n{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"\n{numero} não é um número primo.");
            }
        }
        else
        {
            Console.WriteLine("\nPor favor, insira um número válido.");
        }

        Console.ReadKey(true);
    }

    // Método que verifica se o número é primo
    public static bool VerificarPrimo(int numero)
    {
        if (numero <= 1) // Números menores ou iguais a 1 não são primos
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false; // Se o número for divisível por qualquer número entre 2 e a raiz quadrada dele, não é primo
            }
        }

        return true; // Se não encontrou divisores, é primo
    }
}
