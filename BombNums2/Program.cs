using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] specialBombNumberPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (specialBombNumberPower[0] == numbers[i])
                {
                    for (int p = 0; p < specialBombNumberPower[1]; p++)
                    {
                        if (i < numbers.Count - 1)
                        {
                            numbers.RemoveAt(i + 1);
                        }

                    }
                    for (int p = 0; p < specialBombNumberPower[1]; p++)
                    {
                        if (i > 0)
                        {
                            numbers.RemoveAt(i - 1);
                            i--;
                        }

                    }
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(specialBombNumberPower[0]);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}