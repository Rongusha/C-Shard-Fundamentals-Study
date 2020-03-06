using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var material = string.Empty;
            var quantity = 0;
            var counts = new SortedDictionary<string, int>();
            counts["shards"] = 0;
            counts["fragments"] = 0;
            counts["motes"] = 0;
            var junks = new SortedDictionary<string, int>();
            bool isDone = false;

            while (!isDone)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    if (isDone)
                    {
                        break;
                    }
                    quantity = int.Parse(input[i]);
                    material = input[i + 1].ToLower();

                    switch (material)
                    {
                        case "shards":

                            counts[material] += quantity;

                            if (counts["shards"] >= 250)
                            {
                                isDone = true;
                                Console.WriteLine("Shadowmourne obtained!");
                                counts["shards"] -= 250;

                            }
                            break;

                        case "fragments":


                            counts[material] += quantity;

                            if (counts["fragments"] >= 250)
                            {
                                isDone = true;
                                Console.WriteLine("Valanyr obtained!");
                                counts["fragments"] -= 250;

                            }
                            break;

                        case "motes":

                            counts[material] += quantity;

                            if (counts["motes"] >= 250)
                            {
                                isDone = true;
                                Console.WriteLine("Dragonwrath obtained!");
                                counts["motes"] -= 250;

                            }
                            break;

                        default:
                            if (!junks.ContainsKey(material))
                            {
                                junks[material] = quantity;
                            }
                            else
                            {
                                junks[material] += quantity;
                            }

                            break;
                    }
                }
            }

            var OrderedCounts = counts
                .OrderByDescending(x => x.Value);
            foreach (var item in OrderedCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
