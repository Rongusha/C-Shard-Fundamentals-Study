using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            DoCalculations(dataType);
        }

        static void DoCalculations (string dataType)
        {
            
            if (dataType == "int")
            {
                //TODO:get method to calculate number multiplied by 2
                int number = int.Parse(Console.ReadLine());
                int result = number * 2;
                Console.WriteLine(result);

            }
            else if (dataType == "real")
            {
                //TODO: get method to calculate double number X 1.5 (formated to second decimal point)
                double number = double.Parse(Console.ReadLine());
                double result = number * 1.5;
                Console.WriteLine($"{result:f2}");
            }
            else if (dataType == "string")
            {
                //TODO:put $ in front and at the end
                string input = Console.ReadLine();
                Console.WriteLine($"${input}$");
            }

        }
    }
}
