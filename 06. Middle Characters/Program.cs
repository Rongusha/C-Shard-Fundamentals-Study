using System;
using System.Linq;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = PrintMiddleChars(input);
            Console.WriteLine(result);
        }

        static string PrintMiddleChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                char middleChar = input[input.Length / 2 -1];
                char secondChar = input[input.Length / 2];
                string result = string.Join("", middleChar, secondChar);
                return result;
            }
            else
            {
                char middleChar = input[input.Length / 2];
                return middleChar.ToString();
            }
        }
    }
}
