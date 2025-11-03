using System;

namespace aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aprendizado sobre typecasting em C#
            int n1 = 10;
            float n2 = n1;

            Console.WriteLine("Valor de n2 após typecasting implícito: " + n2);

            // Typecasting explícito
            float n3 = 9.7f;
            int n4 = (int)n3;
            Console.WriteLine("Valor de n4 após typecasting explícito: " + n4);
        }
    }
}