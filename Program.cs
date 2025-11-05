using System;

namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 3;
            Random random = new Random();

            for (int m = 1; m <= 6; m++)
            {
                Console.WriteLine($"Matriz {m}:");

                int[,] matriz = new int[amount, amount];
                int max = int.MinValue;

                // preencher a matriz e descobrir o maior
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < amount; j++)
                    {
                        matriz[i, j] = random.Next(1, 60); // 1..59
                        if (matriz[i, j] > max) max = matriz[i, j];
                    }
                }

                // calcula a largura ideal (nº de dígitos do maior)
                int width = max.ToString().Length + 1; // +1 para um espacinho extra

                // imprimir alinhado
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < amount; j++)
                    {
                       Console.Write($"{matriz[i, j],3}");

                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
