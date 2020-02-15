using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringNumbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int[]> numbers = new List<int[]>();

            for (int i = 0; i < stringNumbers.Count; i++)
            {
                numbers.Add(stringNumbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            }

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                //Console.Write($"{string.Join(" ", numbers[i])} ");
                foreach (var item in numbers[i])
                {
                    Console.Write(item + " ");
                }
                
            }
        }
    }
}
