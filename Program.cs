using System;

namespace Aula09
{
    class Program
    {
        // Ponto de entrada do aplicativo
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("Digite um número inteiro:");
            num = Convert.ToInt32(Console.ReadLine());
            num = num << 1;

            Console.WriteLine(num); 
        }
    }
}