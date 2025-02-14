using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número inteiro: ");
        int primeiroNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro: ");
        int segundoNum = int.Parse(Console.ReadLine());

        // Exibe a soma dos números
        Console.WriteLine($"A soma de {primeiroNum} + {segundoNum} é: {Soma(primeiroNum, segundoNum)}");
        Console.ReadKey(true);
    }

    // Método que retorna a soma dos números
    public static int Soma (int primeiroNum, int segundoNum)
    {
        int somaNumeros = primeiroNum + segundoNum;

        return somaNumeros;
    }
}
