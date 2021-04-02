using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var activationKey = Console.ReadLine();
            var command = string.Empty;
            

            while ((command = Console.ReadLine()) != "Generate")
            {
                var splitted = command.Split(">>>").ToArray();
                var action = splitted[0];
                switch (action)
                {
                    case "Contains":

                        var subString = splitted[1];

                        if (activationKey.Contains(subString))
                        {
                            Console.WriteLine($"{activationKey} contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine($"Substring not found!");
                        }

                        break;

                    case "Flip":

                        var casess = splitted[1];
                        var startIndex = int.Parse(splitted[2]);
                        var endIndex = int.Parse(splitted[3]);
                        var count = endIndex - startIndex;
                        subString = activationKey.Substring(startIndex, count);
                        var toChars = activationKey.ToArray();

                        if (casess == "Upper")
                        {
                            subString = subString.ToUpper();
                            var indexer = 0;
                            for (int i = startIndex; i < endIndex; i++, indexer++)
                            {
                                toChars[i] = subString[indexer];
                            }

                            activationKey = string.Join("", toChars);
                        }
                        else if (casess == "Lower")
                        {
                            subString = subString.ToLower();
                            var indexer = 0;
                            for (int i = startIndex; i < endIndex; i++, indexer++)
                            {
                                toChars[i] = subString[indexer];
                            }

                            activationKey = string.Join("", toChars);
                        }

                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":

                        startIndex = int.Parse(splitted[1]);
                        endIndex = int.Parse(splitted[2]);
                        count = endIndex - startIndex;
                        activationKey = activationKey.Remove(startIndex, count);
                        Console.WriteLine(activationKey);

                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
