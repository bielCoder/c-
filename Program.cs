using System;
using System.IO.Pipelines;

namespace Aula22
{
    // Estrutura inicial de um programa C#

    delegate int Operation(int n1, int n2);

    class Mat
    {
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Double(int n)
        {
            return 2 * n;
        }

        public static int Multi(int n1, int n2)
        {
            return n1 * n2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Aula sobre delegates em C#

            int result,vsoma, vmulti;

            Operation d1 = new Operation(Mat.Sum);
            vsoma = d1(10, 50);

            Operation d2 = new Operation(Mat.Multi);
            vmulti = d2(10, 50);


            Console.WriteLine("Resultado da soma: " + vsoma);
            Console.WriteLine("Resultado da multiplicação: " + vmulti);
            Console.WriteLine("Resultado do dobro: " + Mat.Double(15));
        }
    }
}