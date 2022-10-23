using System;
using System.Linq;

namespace ElementAtOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var result = numbers.ElementAtOrDefault(2);
            var result2 = numbers.ElementAtOrDefault(7);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
