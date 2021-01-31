using System;
using System.Collections.Generic;

namespace Exercises.CollectionsExercises
{
    public class LikesCounter
    {
        public static void CountLikes()
        {
            List<string> inputNames = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals(""))
                {
                    break;
                }

                inputNames.Add(input);
            }

            var inputNamesCount = inputNames.Count;

            if (inputNamesCount == 1)
            {
                Console.WriteLine("{0} likes your post", inputNames[0]);
            }
            else if (inputNamesCount == 2)
            {
                Console.WriteLine("{0} and {1} like your post", inputNames[0], inputNames[1]);
            }
            else if (inputNamesCount > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", inputNames[0], inputNames[1],
                    inputNamesCount - 2);
            }
        }
    }
}