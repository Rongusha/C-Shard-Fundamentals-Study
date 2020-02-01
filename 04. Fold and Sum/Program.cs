using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length<=2)
            {
                int sum = numbers[0] + numbers[1];
                Console.WriteLine(sum);
                return;
            }

            int[] firstRow = new int[numbers.Length / 2];
            int count = (firstRow.Length-1)/2;
            int breakPoint = numbers.Length / 4;
            int loopCount = 0;

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                firstRow[count] = numbers[i];
                count--;
            }

            int index = numbers.Length - 1;
            count =firstRow.Length/2;

            do
            {
                firstRow[count] = numbers[index];
                count++;
                index--;
                loopCount++;
            } while (loopCount < breakPoint);

            int[] secondRow = new int[numbers.Length / 2];
            count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool itExist = false;

                for (int j = 0; j < firstRow.Length; j++)
                {
                    if (numbers[i]==firstRow[j])
                    {
                        itExist = true;
                        break;
                    }
                }

                if (!itExist)
                {
                    secondRow[count] = numbers[i];
                    count++;
                }
            }

            int[] sums = new int[secondRow.Length];

            for (int i = 0; i < sums.Length; i++)
            {
                sums[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sums));
        }
    }
}
