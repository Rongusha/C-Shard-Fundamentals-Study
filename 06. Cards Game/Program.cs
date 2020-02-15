using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            for (int card = 0; card < firstHand.Count;)
            {
                if (firstHand[card] > secondHand[card])
                {
                    firstHand.Add(firstHand[card]);
                    firstHand.Add(secondHand[card]);
                    secondHand.RemoveAt(card);
                    firstHand.RemoveAt(card);
                }
                else if (firstHand[card] == secondHand[card])
                {
                    firstHand.RemoveAt(card);
                    secondHand.RemoveAt(card);
                }
                else if (firstHand[card] < secondHand[card])
                {
                    secondHand.Add(secondHand[card]);
                    secondHand.Add(firstHand[card]);
                    firstHand.RemoveAt(card);
                    secondHand.RemoveAt(card);
                }
                if (firstHand.Count <= 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
                    break;
                }
                else if (secondHand.Count <= 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
                    break;
                }
            }


        }
    }
}
