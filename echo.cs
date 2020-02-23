using System;

namespace Iterations{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                System.Console.Write("Type your name..");
                var input = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(input))
                break;

                System.Console.WriteLine("Echo: " + input);
            }
        }
    }
}