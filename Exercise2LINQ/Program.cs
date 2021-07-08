using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> test = new List<string> { "he", "she", "z" };
            Console.WriteLine($"the last word is {GetTheLastWord(test)}");



        }
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            IEnumerable<string> haveE = words.Select(str => str).Where(str => str.Contains("e"));
            IEnumerable<string> sorted = haveE.OrderBy(str => str);
            string lastWord = sorted.LastOrDefault();

            return lastWord;
        }

    }
}
