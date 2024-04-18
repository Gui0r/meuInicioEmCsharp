using System;

class Program
{
    static void Main(string[]args)
    {
        int n1;
        int n2;
        int soma;
        Console.WriteLine("Digite um número para somar: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());
        soma = n1 + n2;
        Console.WriteLine("Sua soma de números é: ");
        Console.WriteLine(soma);
        Console.ReadKey();
    }
}