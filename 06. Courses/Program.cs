using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                var tokens = command.Split(" : ").ToArray();
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            var ordered = courses.OrderByDescending(x => x.Value.Count);

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var x in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {x}");
                }
            }
        }
    }
}
