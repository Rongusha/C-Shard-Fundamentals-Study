using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static bool CheckIfWeHaveIt(List<string> list, string toCheck)
        {
            bool isThere = true;

            if (list.IndexOf(toCheck) < 0)
            {
                isThere = false;
            }

            return isThere;
        }
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> commands = Console.ReadLine().Split(":").ToList();

            while (commands[0] != "course start")
            {
                string leson = commands[1];
                string exercise = $"{leson}-Exercise";

                switch (commands[0])
                {
                    case "Add":
                        if (!CheckIfWeHaveIt(schedule, leson))
                        {
                            schedule.Add(leson);
                        }
                        break;
                    case "Insert":
                        if (!CheckIfWeHaveIt(schedule, leson))
                        {
                            int index = int.Parse(commands[2]);
                            schedule.Insert(index, leson);
                        }
                        break;
                    case "Remove":
                        if (CheckIfWeHaveIt(schedule, leson))
                        {
                            schedule.Remove(leson);
                        }
                        if (CheckIfWeHaveIt(schedule, exercise))
                        {
                            schedule.Remove(exercise);
                        }
                        break;
                    case "Swap":
                        if (CheckIfWeHaveIt(schedule, leson))
                        {
                            if (CheckIfWeHaveIt(schedule, commands[2]))
                            {
                                int firstIndex = schedule.IndexOf(leson);
                                int secondIndex = schedule.IndexOf(commands[2]);
                                string secondExercise = $"{commands[2]}-Exercise";

                                schedule.Remove(commands[2]);
                                schedule.Insert(firstIndex, commands[2]);
                                schedule.Remove(leson);
                                schedule.Insert(secondIndex, leson);

                                if (CheckIfWeHaveIt(schedule, exercise))
                                {
                                    if (CheckIfWeHaveIt(schedule, secondExercise))
                                    {
                                        schedule.Remove(exercise);
                                        schedule.Insert(secondIndex + 1, exercise);
                                        schedule.Remove(secondExercise);
                                        schedule.Insert(firstIndex + 1, secondExercise);
                                    }
                                    else
                                    {
                                        schedule.Remove(exercise);
                                        schedule.Insert(secondIndex + 1, exercise);
                                    }

                                }
                                else
                                {
                                    if (CheckIfWeHaveIt(schedule, secondExercise))
                                    {
                                        schedule.Remove(secondExercise);
                                        schedule.Insert(firstIndex + 1, secondExercise);
                                    }
                                }
                            }

                        }
                        break;
                    case "Exercise":

                        if (CheckIfWeHaveIt(schedule, leson))
                        {
                            int lesonIndex = schedule.IndexOf(leson);

                            if (!CheckIfWeHaveIt(schedule, exercise))
                            {
                                schedule.Insert(lesonIndex + 1, exercise);
                            }
                        }
                        else
                        {
                            schedule.Add(leson);
                            schedule.Add(exercise);
                        }
                        break;

                    default:
                        break;
                }

                commands = Console.ReadLine().Split(":").ToList();
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }
        }
    }
}
