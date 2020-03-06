using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                while (true)
                {
                    if (text.Contains(word))
                    {
                        text = text.Replace(word, new string('*', word.Length));
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            Console.WriteLine(text);
        }
    }
}
