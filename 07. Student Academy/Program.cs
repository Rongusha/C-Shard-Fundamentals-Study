using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            students = students.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
               
            }
           
        }
    }
}
