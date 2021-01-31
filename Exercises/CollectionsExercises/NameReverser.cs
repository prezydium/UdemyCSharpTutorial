using System;
using System.Linq;

namespace Exercises.CollectionsExercises
{
    public class NameReverser
    {
        public static void askForNameAndReverse()
        {
            Console.WriteLine("Enter your name and see it reversed. SO MUCH FUN!");
            string name = Console.ReadLine();
            char[] output = name.ToCharArray();
            Array.Reverse(output);
            Console.WriteLine(output);
        }
    }
}