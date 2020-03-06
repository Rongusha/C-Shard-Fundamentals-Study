using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int smallestList = Math.Min(firstNums.Count, secondNums.Count);

            for (int i = 0; i < smallestList; i++)
            {
                result.Add(firstNums[i]);
                result.Add(secondNums[i]);

            }

            if (firstNums.Count>secondNums.Count)
            {
                result.AddRange(GetRestOfElements(secondNums, firstNums));
            }
            else
            {
                result.AddRange(GetRestOfElements(firstNums, secondNums));
            }

            Console.WriteLine(String.Join(" ", result));
        }

       static List<int> GetRestOfElements (List<int> first, List<int> second)
        {
            List<int> result = new List<int>();

            for (int i = first.Count; i < second.Count; i++)
            {
                result.Add(second[i]);
            }

            return result;
        }
    }
}
