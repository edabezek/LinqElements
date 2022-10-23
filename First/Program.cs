using System;
using System.Linq;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hüseyin", "Ahmet", "Onur", "Tolgahan" };

            var result = names.First();
            Console.WriteLine(result);//Hüseyin

            Console.ReadLine();
        }
    }
}
