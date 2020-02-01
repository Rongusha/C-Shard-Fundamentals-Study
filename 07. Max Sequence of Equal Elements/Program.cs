using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int count = 0;
            
            int maxCount = 0;
            int oldElement = numbers[0];
            int newElement = 0;
            int numToPrint = numbers[0];


            for (int i = 0; i < numbers.Length-1; i++)
            {
                oldElement = numbers[i];
                newElement = numbers[i + 1];
                if (newElement == oldElement)
                {
                   
                    count++;

                    if (count>maxCount)
                    {
                        maxCount = count;
                        numToPrint = oldElement;

                    }
                }

                else
                {
                    count = 0;

                }
            }

            for (int j = 0; j <= maxCount; j++)
            {
                Console.Write(numToPrint + " ");
            }
        }
    }
}
