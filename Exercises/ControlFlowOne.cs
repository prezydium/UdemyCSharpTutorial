using System;

namespace Exercises
{
    public class ControlFlowOne
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

        public static void DetectSpeedLimit()
        {
            Console.WriteLine("Enter speed limit");
            int speedLimit = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Speed of car");
            int carSpeed = int.Parse(Console.ReadLine()!);
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("It's ok");
            }
            else
            {
               int overSpeed =  carSpeed - speedLimit;
               int points = overSpeed / 5;
               Console.WriteLine("Over speed was {0}, you got {1} points", overSpeed, points);
               if (points > 12)
               {
                   Console.WriteLine("Licence suspended");
               }
            }
            

        }
    }
}