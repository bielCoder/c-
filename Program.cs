using System;

namespace Aula21
{
    class Mat
    {
        public static double pi = 3.14;

        public static int dobro(int n)
        {
            return n * 2;
        }
    }
    class Program
    {

        // ✔️ Use static quando:

        // O comportamento não depende de valores diferentes por objeto.

        // O valor é global.

        // A lógica é pura, sem depender de estado interno.

        // ❌ NÃO use static quando:

        // Cada objeto precisa ter seu próprio estado.

        // O método depende de variáveis internas do objeto.

        static void Main(string[] args)
        {
            // Métodos e Variáveis Estáticas

            double vpi = Mat.pi;
            int num = 10;

            Console.WriteLine("O dobro de " + num + " é " + Mat.dobro(num));
        }
    }
}