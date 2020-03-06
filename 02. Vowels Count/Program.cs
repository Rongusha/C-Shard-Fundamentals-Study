using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            GetVowelsCount(word);
        }

        static void GetVowelsCount(string word)
        {
            int vowelCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char current = word[i];
                if (current=='a' || current=='e' || current=='y' || current=='u' || current=='i' || current =='o'
                    || current == 'A' || current == 'E' || current == 'Y' || current == 'U' || current == 'I' || current == 'O')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}
