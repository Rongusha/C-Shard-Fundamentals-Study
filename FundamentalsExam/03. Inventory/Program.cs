using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
            .Split(", ")
            .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] actions = command.Split(" - ").ToArray();
                string action = actions[0];
                string material = actions[1];


                switch (action)
                {
                    case "Collect":
                        string itemToCheck = items.Find(x => x == material);

                        if (itemToCheck != null)
                        {
                            break;
                        }
                        else
                        {
                            items.Add(material);
                        }
                        break;

                    case "Drop":
                        itemToCheck = items.Find(x => x == material);

                        if (itemToCheck == null)
                        {
                            break;
                        }
                        else
                        {
                            items.Remove(itemToCheck);
                        }
                        break;
                    case "Combine Items":

                        string[] newIItems = material.Split(":").ToArray();
                        itemToCheck = newIItems[0];
                        itemToCheck = items.Find(x => x == newIItems[0]);

                        if (itemToCheck == null)
                        {
                            break;
                        }
                        else
                        {
                            int index = items.IndexOf(itemToCheck);
                            string newItem = newIItems[1];
                            items.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        itemToCheck = items.Find(x => x == material);

                        if (itemToCheck == null)
                        {
                            break;
                        }
                        else
                        {
                            int index = items.IndexOf(itemToCheck);
                            items.Remove(itemToCheck);
                            items.Add(itemToCheck);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
