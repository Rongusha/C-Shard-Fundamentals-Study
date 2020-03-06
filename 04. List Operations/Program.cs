using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
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

            while ((command = Console.ReadLine()) != "End")
            {
                string[] words = command.Split();
                string action = words[0];
                int num;

                switch (action)
                {
                    case "Add":
                        num = int.Parse(words[1]);
                        numbers.Add(num);
                        break;
                    case "Insert":
                        num = int.Parse(words[1]);
                        int indexNum = int.Parse(words[2]);

                        if (indexNum >= numbers.Count || indexNum <0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(indexNum, num);
                        }
                        break;
                    case "Remove":
                        num = int.Parse(words[1]);

                        if (num >= numbers.Count || num<0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(num);
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(words[2]);
                        ShiftTheList(numbers, count, words[1]);
                        break;
                    default:
                        Console.WriteLine("Invalid index");
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void ShiftTheList(List<int> items, int count, string direction)
        {
            int nItem;

            if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    nItem = items[items.Count - 1];     // get the last item of the list
                    items.Remove(nItem);  // remove this item from the end  ...
                    items.Insert(0, nItem);         // ... and insert this (last) item in front of the list
                }
            }
            else if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    nItem = items[0];  //get the first element
                    items.Insert(items.Count, nItem); //insert it at the back of the list
                    items.Remove(items[0]);  //remove the element of the list
                }
            }
        }
    }
}
