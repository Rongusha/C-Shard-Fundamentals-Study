using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thirt = int.Parse(Console.ReadLine());

            GetSmallestNum(first, second, thirt);

        }

        static void GetSmallestNum(int first, int second, int thirt)
        {
            int min = Math.Min(first, second);
            min = Math.Min(min, thirt);
            Console.WriteLine(min);
        }

    }
}
