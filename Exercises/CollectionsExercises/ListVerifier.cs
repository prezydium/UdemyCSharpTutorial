using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.CollectionsExercises
{
    public class ListVerifier
    {
        public static void VerifyAndSort()
        {
            List<int> numbers = new List<int>(); 
            while (true)
            {
                Console.WriteLine("Enter at least 5 integers split by comma");
                string? input = Console.ReadLine();
                numbers = input.Split(",").Select(s => int.Parse(s)).ToList();
                if (numbers.Count >= 5)
                {
                    break;
                }
                Console.WriteLine("Need 5 or more, try again");
            }
            numbers.Sort();
            List<int> output = numbers.GetRange(0, 3);
            Console.WriteLine(string.Join(",", output));
        }
    }
}