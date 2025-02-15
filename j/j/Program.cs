using System;
using System.Collections.Generic;

public class Program
{
    public static int EncontrarMenorNumero(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            throw new ArgumentException("A lista não pode ser nula ou vazia.", nameof(numeros));
        }

        int menorNumero = numeros[0]; // Começamos com o primeiro número da lista

        foreach (int numero in numeros)
        {
            if (numero < menorNumero)
            {
                menorNumero = numero; // Atualizamos o menor número encontrado
            }
        }

        return menorNumero;
        Console.ReadKey(true);
    }

    public static void Main()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Digite os números inteiros. Quando terminar, digite 'sair'.");

        while (true)
        {
            Console.Write("Digite um número: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                break;
            }

            if (int.TryParse(input, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("\nPor favor, insira um número válido.");
            }
        }

        if (numeros.Count > 0)
        {
            int menorNumero = EncontrarMenorNumero(numeros);
            Console.WriteLine($"\nO menor número da lista é: {menorNumero}");
        }
        else
        {
            Console.WriteLine("\nNenhum número foi inserido.");
        }
    }
}