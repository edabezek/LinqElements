using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example0();
            Example1();//Output : 0
            Example2();//Output : 0
            Example3();//Output : 0
        }

        private static void Example3()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };

            int number = numbers.SingleOrDefault(num => num > 10);

            Console.WriteLine(number);
            Console.ReadLine();
        }

        private static void Example2()
        {
            List<int> numbers = new List<int>() { };

            int number = numbers.SingleOrDefault(num => num < 10);

            Console.WriteLine(number);
            Console.ReadLine();
        }

        private static void Example1()
        {
            try
            {
                List<int> numbers = new List<int>() { 10, 20, 30 };

                int number = numbers.SingleOrDefault(num => num < 10);

                Console.WriteLine(number);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("InvalidOperationException: {0}", e.Message);
            }

            Console.ReadLine();
        }

        private static void Example0()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.SingleOrDefault(x => x == 2);
            var result2 = numbers.SingleOrDefault(x => x == 7);

            Console.WriteLine(result);//2
            Console.WriteLine(result2);//0

            Console.ReadLine();
        }
    }
}
