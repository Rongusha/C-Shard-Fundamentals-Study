using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public Student (string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < num; i++)
            {
                string[] initials = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                 
                Student student = new Student(initials[0], initials[1], double .Parse(initials[2]));
                students.Add(student);
            }

            IEnumerable<Student> ordered = students.OrderBy(Student => Student.Grade);
            
            foreach (Student student in ordered.Reverse())
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
