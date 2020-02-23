using System;

namespace Iterations{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                System.Console.WriteLine(i);

                i++;
            }
        }
    }
}