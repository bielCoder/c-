using System;

namespace aula04
{
    class Program
    {
        // Operadores Aritméticos na prática
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            Console.WriteLine("Soma: " + (a + b));          // Adição
            Console.WriteLine("Subtração: " + (a - b));     // Subtração
            Console.WriteLine("Multiplicação: " + (a * b));  // Multiplicação
            Console.WriteLine("Divisão: " + (a / b));        // Divisão
            Console.WriteLine("Módulo: " + (a % b));         // Módulo
        }
    }
}