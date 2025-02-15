using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
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
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        if (numeros.Count > 0)
        {
            double media = CalcularMedia(numeros);
            Console.WriteLine($"A média dos números é: {media}");
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
    
    // Método que retorna o cálculo da média
    public static double CalcularMedia(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            throw new ArgumentException("A lista não pode ser nula ou vazia.", nameof(numeros));
        }

        // Calculando a média
        double soma = numeros.Sum();
        double media = soma / numeros.Count;

        return media;
    }

}
