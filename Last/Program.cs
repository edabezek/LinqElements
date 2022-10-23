using System;
using System.Linq;

namespace Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 15, 20, 25, 5 };

            var result = numbers.Last();

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
