using System;
using System.Linq;

namespace ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ElementAt(2);

            Console.WriteLine(result);
            Console.ReadLine(); 
        }
    }
}
