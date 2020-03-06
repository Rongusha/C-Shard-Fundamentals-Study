using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (count.ContainsKey(wordToLower))
                {
                    count[wordToLower]++;
                }
                else
                {
                    count[wordToLower] = 1;
                }
            }
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }

            }
        }
    }
}
