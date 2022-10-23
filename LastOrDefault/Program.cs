using System;
using System.Linq;

namespace LastOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "one", "two", "three", "four", "five" };
            string[] wordsEmpty = { };

            var result = words.LastOrDefault();
            var resultEmpty=wordsEmpty.LastOrDefault(); 

            Console.WriteLine(resultEmpty); //null
            Console.WriteLine(result); //five

            Console.ReadLine();
        }
    }
}
