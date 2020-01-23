using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <= number.Length-1; i++)
            {
                char current = number[i];
                int digit = int.Parse(current.ToString());
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
