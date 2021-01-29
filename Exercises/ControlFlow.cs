using System;

namespace Exercises
{
    public class ControlFlow
    {
        public static void CheckNumber()
        {
            Console.WriteLine("Enter number between 1 and 10. Don't try anything funny");
            var input = Console.ReadLine();
            var number = int.Parse(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}