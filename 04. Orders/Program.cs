using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();
            var prices = new Dictionary<string, double>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "buy")
            {
                var tokens = command.Split().ToArray();
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);
                
                if (!products.ContainsKey(name))
                {

                    products[name] = quantity;
                }
                else
                {
                    products[name] += quantity;
                }
                if (!prices.ContainsKey(name))
                {
                    prices[name] = price;
                }
                else
                {
                    if (prices[name] != price)
                    {
                        prices[name] = price;
                    }
                }
            }

            var totalPrices = new List<double>();

            foreach (var item in prices)
            {
                totalPrices.Add(item.Value);
            }

            var totalQuantity = new List<double>();

            foreach (var item in products)
            {
                totalQuantity.Add(item.Value);
            }
            for (int i = 0; i < totalQuantity.Count; i++)
            {
                totalPrices[i] *= totalQuantity[i];
            }

            var names = new List<string>();

            foreach (var item in products)
            {
                names.Add(item.Key);
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} -> {totalPrices[i]:f2}");
            }
        }
    }
}
