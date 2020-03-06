using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 11; i <= number; i++)
            {
                if (CheckIfDevisible(i) && CheckForOddDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckIfDevisible(int num)
        {
            bool IsDevisible = false;
            int sum = GetSumOfDigits(num);

            if (sum%8==0)
            {
                IsDevisible = true;
            }

            return IsDevisible;
        }

        

        static bool CheckForOddDigits(int num)
        {
            bool IsValid = false;
            int currentDigit = num;

            while (num>0)
            {
                currentDigit = num % 10;
                num = num / 10;

                if (currentDigit%2!=0)
                {
                    IsValid = true;
                }
                
            }

            return IsValid;
        }

        static int GetSumOfDigits(int num)
        {
            int sumOfDigits = 0;

            while (num>0)
            {
                sumOfDigits += num % 10;
                num = num / 10;
                
            }

            return sumOfDigits;
        }
    }
}
