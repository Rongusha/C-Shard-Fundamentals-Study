using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string material = string.Empty;
            var count = new Dictionary<string, int>();

            while ((material = Console.ReadLine())!="stop")
            {
                 
                int quantity = int.Parse(Console.ReadLine());

                if (!count.ContainsKey(material))
                {
                    count[material] = quantity;
                }
                else
                {
                    count[material] += quantity;
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
