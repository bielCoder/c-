using System;
using System.Globalization;

class Calculator
{
    public int sum(int a, int b) => a + b;
    public int sum(int a, int b, int c) => a + b + c;

    public int factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * factorial(n - 1);
    }
}

class Program
{
    static void Main()
    {
        int res;
        Calculator calculator = new Calculator();

        res = calculator.factorial(10);
        Console.WriteLine("Factorial of 5 is: " + res);
        // int result = ConditionRepeat(calculator); // ← agora recebe um valor

        // Console.WriteLine("You found the secret number 12!");
        // Console.WriteLine("The sum is: " + result);



    }

    // static int ConditionRepeat(Calculator calculator)
    // {
    //     int result;
    //     do
    //     {
    //         Console.WriteLine("Enter the first number:");
    //         int firstnumber = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    //         Console.WriteLine("Enter the second number:");
    //         int secondnumber = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    //         result = calculator.sum(firstnumber, secondnumber);

    //     } while (result != 12);

    //     return result; // ← devolve para o Main
    // }

  
}
