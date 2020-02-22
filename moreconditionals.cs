using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
           var season = Season.Autumn;

           switch (season)
           {
               case Season.Autumn:
               System.Console.WriteLine("It's autumn and a beautiful season!");
           
               case Season.Summer:
               System.Console.WriteLine("It's a perfect time to go to the beach.");
               break;

               default:
                System.Console.WriteLine("I don't understand that season!");
               break;
           
           }
        }
    }
}