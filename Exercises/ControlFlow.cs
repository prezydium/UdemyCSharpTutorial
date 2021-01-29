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

        public static void Compare()
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine()!);
            int result = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine("bigger number was: " + result);
        }

        public static void DetectPortraitOrLandscape()
        {
            Console.WriteLine("Enter first number:");
            int height = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second number:");
            int width = int.Parse(Console.ReadLine()!);
            Console.WriteLine(height >= width ? "Portrait" : "Landscape");
        }
    }
}