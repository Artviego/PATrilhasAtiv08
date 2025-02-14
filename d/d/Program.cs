using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("Insira os números inteiros (digite 'sair' para finalizar):");

        while (true)
        {
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            if (int.TryParse(entrada, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido ou 'sair' para finalizar.");
            }
        }

        // Exibe o maior número
        if (numeros.Count > 0)
        {
            int maiorNumero = EncontrarMaiorNumero(numeros);
            Console.WriteLine("O maior número da lista é: " + maiorNumero);
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }

    //Método que encontra o maior número
    static int EncontrarMaiorNumero(List<int> numeros)
    {
        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        return maior;
    }
}