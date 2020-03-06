using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .ToArray();

            var count = new Dictionary<char, int>();

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char current = word[i];

                    if (!count.ContainsKey(current))
                    {
                        count[current] = 1;
                    }
                    else
                    {
                        count[current]++;
                    }
                   
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
