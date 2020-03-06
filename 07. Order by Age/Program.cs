using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);

                Person person = new Person(name, id, age);
                persons.Add(person);
            }

            List<Person> ordered = persons.OrderBy(x => x.Age).ToList();

            foreach (Person person in ordered)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
