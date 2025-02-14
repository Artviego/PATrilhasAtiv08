using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            Console.WriteLine(ParOuImpar(numero));
        }
        else
        {
            Console.WriteLine("\nEntrada inválida! Tente novamente.");
        }

    }

    public static int ParOuImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.Write("\nO número é verdadeiro(par): ");
        }
        else
        {
            Console.Write("\nO número á falso(ímpar): ");
        }
        return numero;
    }


}