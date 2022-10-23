using System;
using System.Collections.Generic;
using System.Linq;

namespace Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example0();
            Example1(); //Output: 10
            Example2(); //Output : InvalidOperationException : Sequence contains no elements
            Example3(); //Output : InvalidOperationException : Sequence contains more than one element
            Example4(); //Output : 20
            Example5(); //Output : InvalidOperationException : Sequence contains more than one matching element
            Example6(); //Output : InvalidOperationException : Sequence contains no matching element
        }

        private static void Example6()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int number = numbers.Single(num => num < 10);
            Console.WriteLine(number);

            Console.ReadLine();
        }

        private static void Example5()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int number = numbers.Single(num => num > 10);
            Console.WriteLine(number);

            Console.ReadLine();
        }

        private static void Example4()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int number = numbers.Single(num => num == 20);
            Console.WriteLine(number);

            Console.ReadLine();
        }

        private static void Example3()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int number = numbers.Single();
            Console.WriteLine(number);

            Console.ReadLine();
        }

        private static void Example2()
        {
            List<int> numbers = new List<int>() { };
            int number = numbers.Single();
            Console.WriteLine(number);

            Console.ReadLine();
        }

        private static void Example1()
        {
            List<int> numbers = new List<int>() { 10 };
            int number = numbers.Single();
            Console.WriteLine(number);

            Console.ReadLine();
        }

        private static void Example0()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.Single(x => x == 4);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
