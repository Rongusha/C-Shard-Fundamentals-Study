using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int removedSum = 0;

            while (numbers.Count > 0)
            {
                int removeIndex = int.Parse(Console.ReadLine());
                int currentNum = 0;
                

                if (removeIndex < 0)
                {
                    removeIndex = 0;
                    currentNum = numbers[0];
                    numbers.RemoveAt(removeIndex);
                    numbers.Insert(removeIndex, numbers[numbers.Count - 1]);
                    removedSum += currentNum;
                    numbers = DoTheMaths(numbers, currentNum);
                }
                else if (removeIndex > numbers.Count - 1)
                {
                    removeIndex = numbers.Count - 1;
                    currentNum = numbers[removeIndex];
                    numbers.RemoveAt(removeIndex);
                    numbers.Insert(removeIndex, numbers[0]);
                    removedSum += currentNum;
                    numbers = DoTheMaths(numbers, currentNum);
                }
                else
                {
                    currentNum = numbers[removeIndex];
                    numbers.RemoveAt(removeIndex);
                    removedSum += currentNum;
                    numbers = DoTheMaths(numbers, currentNum);
                }

            }

            Console.WriteLine(removedSum);
        }

        static List<int> DoTheMaths(List<int> list, int num)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= num)
                {
                    list[i] += num;
                }
                else
                {
                    list[i] -= num;
                }
            }

            return list;
        }
    }
}
