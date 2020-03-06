using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> actionNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNum = actionNums[0];
            int powerNum = actionNums[1];
            int bombIndex = numbers.IndexOf(bombNum);
           
            while (bombIndex>=0)
            {
                for (int i = 0; i < powerNum; i++)
                {
                    if (bombIndex < numbers.Count-1)
                    {
                        numbers.RemoveAt(bombIndex + 1);
                    }
                }

                for (int i = 0; i < powerNum; i++)
                {
                    if (bombIndex >0)
                    {
                        numbers.RemoveAt(bombIndex - 1);
                        bombIndex--;
                    }
                }

                numbers.RemoveAt(bombIndex);
                bombIndex = numbers.IndexOf(bombNum);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
