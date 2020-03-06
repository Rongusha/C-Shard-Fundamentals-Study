using System;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string reverced = "";
                for (int i = command.Length-1; i >= 0; i--)
                {
                    reverced += command[i];
                }
                Console.WriteLine($"{command} = {reverced}");
            }
        }
    }
}
