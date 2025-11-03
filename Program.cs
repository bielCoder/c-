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
            firstNote = float.Parse(Console.ReadLine()); 
            Console.Write("Digite a segunda nota:");
            secondNote = float.Parse(Console.ReadLine());


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