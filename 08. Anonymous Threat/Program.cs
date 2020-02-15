using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> anything = Console.ReadLine().Split().ToList();

            string command = string.Empty;
            string[] actions = Console.ReadLine()
                       .Split()
                       .ToArray();

            while (actions[0] != "3:1")
            {
                
                if (actions[0] == "merge")
                {
                   
                    int startIndex =int.Parse(actions[1]);
                    int endIndex = int.Parse(actions[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > anything.Count-1)
                    {
                        startIndex = anything.Count - 1;
                    }
                    if (endIndex > anything.Count - 1)
                    {
                        endIndex = anything.Count - 1;
                    }
                    else if (endIndex<0)
                    {
                        endIndex = 0;
                    }

                    List<string> temp = new List<string>();

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        temp.Add(anything[i]);
                        
                    }

                    anything[startIndex] = string.Join("", temp);

                    for (int i = startIndex+1; i <= endIndex; i++)
                    {
                        anything.RemoveAt(startIndex + 1);
                    }
                }
                else if (actions[0] == "divide")
                {
                    int itemIndex = int.Parse(actions[1]);
                    int itemNumbers = int.Parse(actions[2]);
                    string current = anything[itemIndex];
                    int charsInIndex = current.Length / itemNumbers;
                    int extraChars = current.Length % itemNumbers;
                    string toString = string.Empty;
                    int currentIndex = 0;
                    
                    for (int j = 0; j < itemNumbers; j++)
                    {
                        if (j == itemNumbers - 1)
                        {
                            charsInIndex += extraChars;
                        }

                        toString = current.Substring(currentIndex, charsInIndex);
                        anything.Insert(itemIndex+1+j, toString);
                        currentIndex += charsInIndex;
                    }

                    anything.RemoveAt(itemIndex);
                }

                actions = Console.ReadLine()
                       .Split()
                       .ToArray();
            }

            Console.WriteLine(string.Join(" ", anything));
        }
    }
}
