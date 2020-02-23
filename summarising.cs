using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
         var sentence = "This is going to be a really really reallly really really really reallllllly long text.";
         var summary = SummarizeText(sentence);
         System.Console.WriteLine(summary);
            }

        static string SummerizeTex(string text, int maxLength = 20)
        {

         if(text.Length < maxLength)
            return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();


            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if(totalCharacters > maxLength)
                    break;
            }
               return String.Join(" ", summaryWords) + "...";
        }
    }
}