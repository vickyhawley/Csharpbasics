using System;

namespace Iterations{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";

            //for (var i = 0; 1 < name.Length; i++)
            //{
             // System.Console.WriteLine(name[i]);
            //}

            foreach ( var character in name)
            {
                System.Console.WriteLine(character);
            }
        }
    }
}