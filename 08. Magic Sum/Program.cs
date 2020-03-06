using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            int currentNum = 0;
            int newNum = 0;
            int currentSum = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                currentNum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    newNum = numbers[j];
                    currentSum = currentNum + newNum;

                    if (currentSum == sum)
                    {
                        Console.Write($"{currentNum} {newNum}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
