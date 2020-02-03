using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            //TODO:make an Array same size
            int[] field = new int[fieldSize];

            int[] indexess = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); // where the lady bugs are

            foreach (var index in indexess)
            {
                if (index < 0 || index > fieldSize - 1)
                {
                    continue;
                }

                field[index] = 1;
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                //TODO:split action to 3 different varaibles and move the lady bugs from 1 place to another
                string[] action = command.Split(" ");
                int bugPosition = int.Parse(action[0]);
                string movingDirection = action[1];
                int movingLenght = int.Parse(action[2]);

                if (bugPosition < 0 || bugPosition >= fieldSize || field[bugPosition] == 0)
                {
                    continue;
                }

                if (movingDirection == "right")
                {
                    field[bugPosition] = 0;
                    int newPosition = bugPosition + movingLenght;

                    while (newPosition < fieldSize)
                    {
                        if (field[newPosition] == 1)
                        {
                            newPosition += movingLenght;
                            continue;
                        }

                        field[newPosition] = 1;
                        break;

                    }
                }

                if (movingDirection == "left")
                {
                    field[bugPosition] = 0;
                    int newPosition = bugPosition - movingLenght;

                    while (newPosition >= 0)
                    {
                        if (field[newPosition] == 1)
                        {
                            newPosition -= movingLenght;
                            continue;
                        }

                        field[newPosition] = 1;
                        break;

                    }
                }

            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
