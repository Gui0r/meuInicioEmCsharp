using System;

class Program
{
    static void subtrair(string[]args){
        int n1;
        int n2;
        int subtracao;
        Console.WriteLine("Digite um número para subtrair: ");
        n1 = int.Parse(Console.Readline());
        Console.WriteLine("Digite o segundo número para subtrair: ");
        n2 = int.Parse(Console.Readline());
        subtracao = n1 + n2;
        Console.WriteLine(subtracao);
        Console.ReadKey();
    }
    static void somar(string[]args){
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
    static void multiplicar(string[]args){
        int n1;
        int n2;
        int multiplicar;
        Console.WriteLine("Digite um número para multiplicar: ");
        n1 = int.Parse(Console.Readline());
        Console.WriteLine("Digite o segundo número para multiplicar: ");
        n2 = int.Parse(Console.ReadLine());
        multiplicar = n1 + n2;
        Console.WriteLine(" Sua multiplicar de números é: ");
        Console.WriteLine(multiplicar);
        Console.ReadKey();
    }
    static void divisao(string[]args){
        int n1;
        int n2;
        int divisao;
        Console.WriteLine("Digite um número para dividir: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número para dividir: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine(" Sua divisao de números é: ");
        Console.WriteLine(divisao);
        Console.ReadKey();

    }

     static void Main(string[]args)
    {
        int escolha;
        Console.WriteLine("Escolha uma operação: ");
        Console.WriteLine("1 para soma: ");
        Console.WriteLine("2 para subtração: ");
        Console.WriteLine("3 para multiplicação: ");
        Console.WriteLine("4 para divisão: ");
        escolha = int.Parse(Console.ReadLine());

        if(escolha = 1){
            somar();
        }else if(escolha = 2){
            subtrair();
        }else if(escolha = 3){
            multiplicar();
        }else if(escolha = 4){
            divisao();
        }else{
            Console.WriteLine("Essa opção não existe");
        }
    }
}