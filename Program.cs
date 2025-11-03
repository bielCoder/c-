using System;

namespace aula08
{
    class Program
    {
        static int result;    
        static void Main(string[] args)
        {
            int v1, v2, soma;
    
            // string nome;

            // Console.WriteLine("Digite seu nome:");
            // nome = Console.ReadLine();
            // Console.WriteLine("O nome digitado foi: " + nome);

            Console.WriteLine("Digite o primeiro valor:");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O primeiro valor digitado foi: " + v1);
            Console.WriteLine("O segundo valor digitado foi: " + v2);
            soma = Somar(v1, v2);
            Console.WriteLine("A soma dos dois valores é: " + soma);
        }
        
        static int Somar(int a, int b)
        {
           return a + b;
        }
    }
}