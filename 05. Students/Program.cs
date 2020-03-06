using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] actions = command.Split(" ");
                string firstName = actions[0];
                string lastName = actions[1];   
                int age = int.Parse(actions[2]);
                string homeTown = actions[3];

                if (IsExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };

                    students.Add(student);
                }
            }

            string city = Console.ReadLine();
            List<Student> filteredStudents = students.Where(j => j.HomeTown == city).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public static bool IsExisting(List<Student> students, string firstName, string secondName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == secondName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent (List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}

