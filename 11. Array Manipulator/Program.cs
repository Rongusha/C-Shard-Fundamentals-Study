using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = string.Empty;

            while (( command = Console.ReadLine()) !="end")
            {

            }
        }
    }
}
