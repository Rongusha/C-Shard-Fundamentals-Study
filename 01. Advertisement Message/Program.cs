using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

           List<string> phrases = new List<string>() 
           {
               "Excellent product.",
               "Such a great product.",
               "I always use that product.",
               "Best product of its category.",
               "Exceptional product.",
               "I can’t live without this product." 
           };

            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> autors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> cities = new List<string>() 
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" 
            };

            Random random = new Random();
            int randomIndex = 0;

            for (int i = 1; i <= num; i++)
            {
                randomIndex = random.Next(6);
                Console.WriteLine($"{phrases[randomIndex]} {events[randomIndex]} {autors[randomIndex]} {cities[randomIndex]}");
            }
        }
    }
}
