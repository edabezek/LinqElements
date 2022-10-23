using System;
using System.Linq;

namespace FirstOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Turkey", "India", "Russian", "Italy" };
            string[] empty = { };


            var result = countries.FirstOrDefault();
            var resultEmpty=empty.FirstOrDefault();

            Console.WriteLine(result);  //Turkey
            Console.WriteLine(resultEmpty); //null

            Console.ReadLine();
        }
    }
}
