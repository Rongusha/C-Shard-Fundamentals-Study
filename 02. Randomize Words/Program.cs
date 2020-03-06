using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random result = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int j = result.Next(words.Count);
                string first = words[i];
                string second = words[j];
                words[i] = second;
                words[j] = first;
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
