using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double aditionalBonus = double.Parse(Console.ReadLine());
            double bestStudent = double.MinValue;
            double totalBonus = 0;
            if (studentCount>0)
            {
                for (int i = 0; i < studentCount; i++)
                {
                    int atendedClasses = int.Parse(Console.ReadLine());

                    if (atendedClasses >= bestStudent)
                    {
                        bestStudent = atendedClasses;
                    }
                }

                totalBonus = Math.Ceiling((bestStudent / lecturesCount) * (5 + aditionalBonus));
            }
            else
            {
                totalBonus = aditionalBonus;
                bestStudent = 0;
            }
            Console.WriteLine($"Max Bonus: {totalBonus}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
