using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour >  0 && hour < 12)
            System.Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour < 18)
            System.Console.WriteLine("It's afternoon.");
            else
            System.Console.WriteLine("It's evening.");
        }
    }
}