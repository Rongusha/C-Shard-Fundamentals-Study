using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count[item] = 1;
                }
            }
            foreach (var num in count)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
