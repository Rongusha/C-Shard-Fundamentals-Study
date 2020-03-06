using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var wordToCheck = Console.ReadLine();
            int index = 0;
            while (index>=0)
            {
                index = wordToCheck.IndexOf(word);
                if (index<0)
                {
                    break;
                }
               wordToCheck= wordToCheck.Remove(index, word.Length);
            }

            Console.WriteLine(wordToCheck);
        }
    }
}
