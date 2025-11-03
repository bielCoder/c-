using System;

namespace Aula10
{
    class Program
    {
        enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        static void Main(string[] args)
        {
            int today = (int) WeekDays.Monday;
            Console.WriteLine("Today is: " + today);
        }
    }
}