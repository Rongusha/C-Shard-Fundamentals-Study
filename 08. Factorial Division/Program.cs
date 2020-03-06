using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstFactorial = GetFactorial(firstNum);
            double secondFactorial = GetFactorial(secondNum);

            double result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorial(double num)
        {
            double factorial = 1;
            

            for (double i = num; i > 0; i--)
            {
                factorial = factorial * i;
                
            }
            return factorial;
        }
    }
}
