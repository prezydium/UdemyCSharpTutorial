using System;
using System.Collections.Generic;

namespace Exercises.CollectionsExercises
{
    public class UniqueFilter
    {
        public static void displayUnique()
        {
            List<int> inputNumbers = new List<int>();
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input.Equals("Quit"))
                {
                    break;
                }

                inputNumbers.Add(int.Parse(input));
            }

            HashSet<int> setOfNumbers = new HashSet<int>(inputNumbers);
            Console.WriteLine("Unique numbers are: " + string.Join(",", setOfNumbers));
        }
    }
}