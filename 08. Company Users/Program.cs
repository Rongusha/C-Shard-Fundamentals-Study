using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new Dictionary<string, List<string>>();
            string command = string.Empty;
            bool isThere = false;
            while ((command = Console.ReadLine())!="End")
            {
                var tokens = command.Split(" -> ").ToArray();
                string company = tokens[0];
                string worker = tokens[1];

                if (!workers.ContainsKey(company))
                {
                    workers[company] = new List<string>();
                    workers[company].Add(worker);
                }
                else
                {
                    foreach (var item in workers)
                    {
                        foreach (var x in item.Value)
                        {
                            if (x==worker)
                            {
                                isThere = true;
                                break;
                            }
                           
                        }
                    }
                    if (!isThere)
                    {
                        workers[company].Add(worker);
                    }
                    
                }
            }

           
            foreach (var item in workers.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var x in item.Value)
                {
                    Console.WriteLine($"-- {x}");
                }
            }
        }
    }
}
