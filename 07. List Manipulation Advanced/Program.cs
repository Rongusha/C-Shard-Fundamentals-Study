using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            bool isSame = true;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] words = command.Split(" ");
                string action = words[0];
                int num;

                switch (action)
                {
                    case "Contains":
                        num = int.Parse(words[1]);
                        bool isThere = numbers.Contains(num);
                        if (isThere)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNums = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNums.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", evenNums));
                        break;
                    case "PrintOdd":
                        List<int> oddNums = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                oddNums.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", oddNums));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        num = int.Parse(words[2]);
                        string condition = words[1];
                        List<int> filteredNums = new List<int>();
                        filteredNums = GetFileteredNumbers(numbers, condition, num);
                        Console.WriteLine(string.Join(" ", filteredNums));
                        break;
                    case "Add":
                        isSame = false;
                        num = int.Parse(words[1]);
                        numbers.Add(num);
                        break;
                    case "Remove":
                        isSame = false;
                        num = int.Parse(words[1]);
                        numbers.Remove(num);
                        break;
                    case "RemoveAt":
                        isSame = false;
                        num = int.Parse(words[1]);
                        numbers.RemoveAt(num);
                        break;
                    case "Insert":
                        isSame = false;
                        num = int.Parse(words[1]);
                        int indexNum = int.Parse(words[2]);
                        numbers.Insert(indexNum, num);
                        break;

                    default:
                        Console.WriteLine("invalid Command");
                        break;
                }
            }

            if (!isSame)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> GetFileteredNumbers (List<int> numbers ,string condition, int num)
        {
            List<int> filteredNums = new List<int>();

            switch (condition)
            {
                case "<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < num)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }

                    return filteredNums;
                    
                case ">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > num)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }

                    return filteredNums;
                case ">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= num)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }

                    return filteredNums;
                case "<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= num)
                        {
                            filteredNums.Add(numbers[i]);
                        }
                    }

                    return filteredNums;
                default:
                    return filteredNums;
            }
        }
    }
}
