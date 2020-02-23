using System;

namespace CSharpFundamentals{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Victoria Hawley ";
            Console.WriteLine("Trim: '{0}", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: " + names[0]);
            System.Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Victoria", "Vix"));

            if (String.IsNullOrWhiteSpace(" "));
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            price.ToString("C");
            
        }
    }
}