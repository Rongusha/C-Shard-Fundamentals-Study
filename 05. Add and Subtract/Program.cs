using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

           int sum = Subtracts(first, second, third);

            Console.WriteLine(sum);
        }

        static int GetSum (int first, int second)
        {
            int sum = first + second;
            return sum;

        }

        static int Subtracts (int first, int second, int third)
        {

            int sum = GetSum(first, second) - third;
            return sum;
        }
    }
}
