using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] names = new string[num];
            int[] sums = new int[num];

            int currentSum = 0;

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
                string current = names[i];

                for (int j = 0; j < current.Length; j++)
                {
                    char currentChar = current[j];
                    int charToInt = currentChar;

                    if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u'
                        || currentChar == 'A' || currentChar == 'E' || currentChar == 'I' || currentChar == 'O' || currentChar == 'U')
                    {
                        currentSum += charToInt * current.Length;
                    }
                    else 
                    {
                        currentSum += charToInt / current.Length;
                    }
                }

                sums[i] = currentSum;
                currentSum = 0;
            }

            int[] newSums = new int[num];
            int index = 0;

            for (int i = 0; i < sums.Length; i++)
            {
                for (int j = 0; j < sums.Length; j++)
                {
                    if (sums[j] == sums.Min())
                    {
                        newSums[index] = sums[j];
                        index++;
                        sums[j] = int.MaxValue;
                        break;
                    }
                }
            }

            for (int i = 0; i < newSums.Length; i++)
            {
                Console.WriteLine(newSums[i]);
            }
        }
    }
}
