using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pplInWagon = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int newPpl = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                bool isNum = int.TryParse(command, out newPpl);
                string[] action = command.Split();

                if (action[0] == "Add")
                {
                    pplInWagon.Add(Convert.ToInt32(action[1]));
                }
                else if (isNum)
                {
                    for (int i = 0; i < pplInWagon.Count; i++)
                    {
                        if (pplInWagon[i] + newPpl <= wagonCapacity)
                        {
                            pplInWagon[i] += newPpl;
                            break;
                        }
                    }
                }
                
            }

            Console.WriteLine(String.Join(" ", pplInWagon));
        }
    }
}
