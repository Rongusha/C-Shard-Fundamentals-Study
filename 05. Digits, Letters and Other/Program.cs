using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                
                if (char.IsDigit(word[i]))
                {
                    digits += word[i];
                }
                else if(char.IsLetter(word[i]))
                {
                    letters += word[i];
                }
                else 
                {
                    symbols += word[i];
                }
            }

            Console.WriteLine($"{digits}\n{letters}\n{symbols}");
        }
    }
}
