using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        string resultado = ObterCaracteresImpares(entrada);
        Console.WriteLine("A nova string com caracteres em posições ímpares é: " + resultado);
    }

    static string ObterCaracteresImpares(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str), "A string não pode ser nula.");
        }

        string resultado = "";

        for (int i = 0; i < str.Length; i++)
        {
            // Verifica se a posição é ímpar (considerando 0 como par)
            if (i % 2 != 0)
            {
                resultado += str[i];
            }
        }

        return resultado;
    }
}