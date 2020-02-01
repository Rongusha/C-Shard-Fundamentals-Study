using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine())!="END")
            {
                
                int num = int.Parse(command);

                CheckIfPalidrome(num);
                
            }
             
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void CheckIfPalidrome(int num)
        {
            
            string number = num.ToString();
            string reversed = ReverseString(number);

            if (number == reversed)
            {
                Console.WriteLine("true");
                
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
