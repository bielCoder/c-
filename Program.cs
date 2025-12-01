using System;
using System.Globalization;

class Calculator
{
    public int sum(int a, int b)
    {
        return a + b;
    }

    public int sum(int a, int b, int c)
    {
        return a + b + c;
    }
}
// Aula de Sobrecarga de Métodos
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        int result; // ← DECLAREI AQUI

        do
        {
            Console.WriteLine("Enter the first number:");
            int firstnumber = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the second number:");
            int secondnumber = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            result = calculator.sum(firstnumber, secondnumber);

        } while (result != 12);  // ← TERMINA AQUI (SEM OUTRO BLOCO)

        Console.WriteLine("You found the secret number 12!");
        Console.WriteLine("The sum is: " + result);
    }
}
