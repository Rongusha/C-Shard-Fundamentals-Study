using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            string info = string.Empty;

            for (int i = 0; i < num; i++)
            {
                info = Console.ReadLine();
                string[] person = info.Split();
                int indexOfName = names.IndexOf(person[0]);

                if (person[2] == "going!")
                {
                    if (indexOfName < 0)
                    {
                        names.Add(person[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{person[0]} is already in the list!");
                    }
                }
                else if (person[2] == "not")
                {
                    if (indexOfName < 0)
                    {
                        Console.WriteLine($"{person[0]} is not in the list!");
                    }
                    else
                    {
                        names.Remove(person[0]);
                    }
                }
               
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
