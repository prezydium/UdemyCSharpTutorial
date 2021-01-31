using System;
using System.Collections.Generic;

namespace Exercises.CollectionsExercises
{
    public class UniqueNumberDisplayer
    {
        public static void displayUnique()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 5 unique numbers");
            for (int i = 0; i < 5; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Not unique! Try again");
                    i--;
                }
                else
                {
                    numbers.Add(input);
                }
            }
            Console.WriteLine("Unique numbers entered: " + string.Join(",", numbers));
        }
    }
}