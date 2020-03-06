using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (rows == 1)
            {
                return;
            }

            int[] firstArr = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", firstArr));

            if (rows == 2)
            {
                return;
            }

            else
            {
                for (int i = 0; i < firstArr.Length + 1; i++)
                {
                    int[] secondArr = new int[firstArr.Length + 1];
                    secondArr[0] = 1;
                    secondArr[secondArr.Length - 1] = 1;

                    for (int j = 1; j < secondArr.Length - 1; j++)
                    {
                        secondArr[j] = firstArr[j - 1] + firstArr[j];
                    }
                    Console.WriteLine(string.Join(" ", secondArr));

                    firstArr = secondArr;

                    if (firstArr.Length == rows)
                    {
                        break;
                    }
                }
            }
        }
    }
}
