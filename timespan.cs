using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine("duration: " + duration);

            //Properties

            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add or subtract
            System.Console.WriteLine("Add Examples: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine("Subtract Examples: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            //ToString 
            System.Console.WriteLine("ToString" + timeSpan.ToString());

            //Parse
            System.Console.WriteLine("Parse: " + timeSpan.Parse("01:02:03"));

        }
    }
}