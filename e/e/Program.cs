using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<string> palavras = new List<string>();
        Console.WriteLine("Insira as strings que deseja concatenar (digite 'sair' para finalizar):");

        while (true)
        {
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            palavras.Add(entrada);
        }

        if (palavras.Count > 0)
        {
            string resultado = ConcatenarStrings(palavras);
            Console.WriteLine("A string concatenada é: " + resultado);
        }
        else
        {
            Console.WriteLine("Nenhuma string foi inserida.");
        }
    }

    static string ConcatenarStrings(List<string> strings)
    {
        if (strings == null)
        {
            throw new ArgumentNullException(nameof(strings), "A lista não pode ser nula.");
        }

        return string.Join(" ", strings);
    }
}