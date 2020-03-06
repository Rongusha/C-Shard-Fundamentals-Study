using System;

namespace CardsResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int aTeamSum = 0;
            int bTeamSum = 0;
            int biggest = 0;

            while (biggest<151)
            {
                int aPoints =int.Parse(Console.ReadLine());
                int bPoints = int.Parse(Console.ReadLine());
                aTeamSum += aPoints;
                bTeamSum += bPoints;
                
                if (aTeamSum>bTeamSum)
                {
                    biggest = aTeamSum;
                }
                else
                {
                    biggest = bTeamSum;
                }

                Console.WriteLine($"Viktor i Jivko imat {aTeamSum}");
                Console.WriteLine($"Todor i Adasha imat {bTeamSum}");
            }

            if (aTeamSum>bTeamSum)
            {
                Console.WriteLine("Chestito na Viktor i Jivaka za dobrata igra");
            }
            else
            {
                Console.WriteLine("Adasha i todor biqt i tazi igra! probvaite pak sledvashtiq pyt");
            }
        }
    }
}
