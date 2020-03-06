using System;
using System.Linq;

namespace ArratManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] actions = Console.ReadLine().Split().ToArray();

            while (actions[0] != "end")
            {
                string command = actions[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(actions[1]);

                        break;

                    case "max":
                        string type = actions[1];

                        GetMax(numbers, type);

                        break;
                    case "min":
                        type = actions[1];

                        GetMin(numbers, type);

                        break;

                    case "first":
                        index = int.Parse(actions[1]);
                        type = actions[2];
                        int count = 0;

                        if (type == "even")
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 == 0)
                                {
                                    Console.WriteLine(numbers[i]);
                                    count++;
                                }
                                if (count == index)
                                {
                                    break;
                                }
                            }
                        }
                        else if (type == "odd")
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    Console.WriteLine(numbers[i]);
                                    count++;
                                }
                                if (count == index)
                                {
                                    break;
                                }
                            }
                        }

                        break;
                }
            }
        }

        static void GetMin(int[] numbers, string type)
        {

            if (type == "even")
            {
                int minEven = int.MaxValue;
                int minIndex = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= minEven)
                        {
                            minEven = numbers[i];
                            minIndex = i;
                        }
                    }
                    if (minIndex == 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
            }
            else if (type == "odd")
            {
                int minOdd = int.MaxValue;
                int minIndex = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= minOdd)
                        {
                            minOdd = numbers[i];
                            minIndex = i;
                        }
                    }
                    if (minIndex == 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
            }
        }

        static void GetMax(int[] numbers, string type)
        {

            if (type == "even")
            {
                int maxEven = int.MinValue;
                int maxIndex = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= maxEven)
                        {
                            maxEven = numbers[i];
                            maxIndex = i;
                        }
                    }
                }
                if (maxIndex == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }
            else if (type == "odd")
            {
                int maxOdd = int.MinValue;
                int maxIndex = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= maxOdd)
                        {
                            maxOdd = numbers[i];
                            maxIndex = i;
                        }
                    }
                }
                if (maxIndex == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }
        }
    }
}

