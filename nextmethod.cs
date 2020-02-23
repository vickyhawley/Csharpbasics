using System;
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            System.Console.WriteLine(randomNext(1, 10));
        }
    }
}
