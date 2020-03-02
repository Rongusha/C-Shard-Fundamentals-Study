using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|")
                .ToArray();

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] actions = rooms[i].Split(" ").ToArray();
                string founds = actions[0];
                int quantity = int.Parse(actions[1]);

                if (founds == "potion")
                {
                    //TODO get extra health but no more than 100
                    int difference = 100 - health;
                    health += quantity;
                    if (health > 100)
                    {
                        health = 100;
                        Console.WriteLine($"You healed for {difference} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {quantity} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (founds == "chest")
                {
                    //TODO get extra bitcoins (no limit)

                    bitcoins += quantity;

                    Console.WriteLine($"You found {quantity} bitcoins.");
                }
                else
                {
                    //TODO fight with monster and take off health no less than 0

                    health -= quantity;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {founds}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {founds}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
