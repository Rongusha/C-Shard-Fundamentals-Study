using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .Where(n => n.Length % 2 == 0)
                .ToArray();

            foreach (var x in words)
            {
                Console.WriteLine(x);
            }



        }
    }
}
