using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
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

            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();

                if (action[0] == "Delete")
                {
                    int numToDelete = int.Parse(action[1]);
                    numbers.RemoveAll(numbers => numToDelete == numbers);
                }
                else if (action[0] == "Insert")
                {
                    int index = int.Parse(action[2]);
                    int num = int.Parse(action[1]);
                    numbers.Insert(index, num);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
