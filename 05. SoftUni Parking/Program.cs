using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                string action = command[0];
                string username = command[1];

                switch (action)
                {
                    case "register":
                        string licenseNum = command[2];
                        if ((!data.ContainsKey(username)))
                        {
                            data[username] = licenseNum;
                            Console.WriteLine($"{username} registered {licenseNum} successfully");
                        }
                        else if (data.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licenseNum}");
                        }

                        break;
                    case "unregister":
                        if (!data.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            data.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }

                        break;
                    default:
                        break;
                }
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
