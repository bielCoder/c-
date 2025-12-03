using System;

namespace Areas
{
    class Area
    {
        public static float Square(float baseLength, float altura)
        {
            if (baseLength == 0 || altura == 0)
            {
                throw new ArgumentException("Base ou altura não podem ser zero.");
            }

            return baseLength * altura;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
       
        try
        {
            float area = Areas.Area.Square(0, 5);
            Console.WriteLine($"Área do quadrado.:{0} {area}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}.:{0}");
        } finally
        {
            Console.WriteLine("Execução finalizada.");
        }   
    }
}