using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }

                synonyms[word].Add(synonym);
            }
            foreach (var item in synonyms)
            {
                var word = item.Key;
                var synonym = item.Value;
                Console.WriteLine($"{word} - {string.Join(", ",synonym)}");
            }
        }
    }
}
