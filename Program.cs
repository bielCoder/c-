using System;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula sobre argumentos passados via terminal
            Console.WriteLine("A quantidade de argumentos é: " + args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argumento {i + 1}: {args[i]}");
                Console.WriteLine("A soma dos argumentos numéricos é: " + (int.Parse(args[i]) + int.Parse(args[i])) );

            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Hello,{args[0]}" );
        }
    }
}