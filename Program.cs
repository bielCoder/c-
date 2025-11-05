using System;
using System.Security.Cryptography;

namespace aula12
{
    class Program
    {
        // static int age = 12;
        static float firstNote;
        static float secondNote;
        static void Main(string[] args)
        {
            // aula de condicionais if e else
            // if(age < 18)
            // {
            //     Console.WriteLine("Acesso negado. Menores de 18 anos não são permitidos.");
            // } else
            // {
            //     Console.WriteLine("Acesso permitido. Bem-vindo!");
            // }
            Console.Write("Digite a primeira nota:");
            string? input1 = Console.ReadLine();
            firstNote = string.IsNullOrEmpty(input1) ? 0 : float.Parse(input1);
            Console.Write("Digite a segunda nota:");
            string? input2 = Console.ReadLine();
            secondNote = string.IsNullOrEmpty(input2) ? 0 : float.Parse(input2);


            CalculateAverage((float) firstNote,(float) secondNote);


        }


        static void CalculateAverage(float firstNote, float secondNote)
        {
            float average = (firstNote + secondNote) / 2;
            Console.WriteLine("Média: " + average);

            if (average >= 6)
            {
                Console.WriteLine("Resultado: Aprovado");
            }
            else
            {
                Console.WriteLine("Resultado: Reprovado");
            }
        }
    }
}