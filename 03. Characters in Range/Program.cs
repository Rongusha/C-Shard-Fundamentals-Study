using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintAllChars(first, second);
        }

        static void PrintAllChars (char first, char second)
        {
            if (first<second)
            {
                for (int i = (first + 1); i < second; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = second+1; i < first; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            
        }
    }
}
