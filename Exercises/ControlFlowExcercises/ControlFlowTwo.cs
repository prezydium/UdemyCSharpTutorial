using System;

namespace Exercises.ControlFlowExcercises
{
    public class ControlFlowTwo
    {
        public static void PrintDivisibleByThree()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("there are {0} numbers divisible by 3", count);
        }

        public static void CountWithExitOption()
        {
            int currentSum = 0;
            while (true)
            {
                Console.WriteLine("Enter number to add up or OK to exit");
                string input = Console.ReadLine();
                if (input.Equals("OK"))
                {
                    break;
                }

                currentSum += int.Parse(input);
                Console.WriteLine("Current sum: " + currentSum);
            }
        }

        public static void CountAndDisplayFactorial()
        {
            Console.WriteLine("Enter number to have factorial calculated");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine("Factorial of {0} is {1}", number, result);
        }

        public static void GuessRandomNumber()
        {
            int chances = 3;
            int randomNumber = new Random().Next(10) + 1;
            bool success = false;
            Console.WriteLine("Guess random number. [debug:{0}]", randomNumber);
            while (chances > 0 && !success)
            {
                int guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber == randomNumber)
                {
                    success = true;
                }
                else
                {
                    chances--;
                }
            }
            if (success)
            {
                Console.WriteLine("YOU WON!");
            }
        }

        public static void GetHighest()
        {
            Console.WriteLine("Enter comma separated integers to get the highest");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(",");
            if (splitInput.Length < 1)
            {
                throw new Exception("Empty input");
            }

            int[] numbers = new int[splitInput.Length];
            for (int i = 0; i < splitInput.Length; i++)
            {
                numbers[i] = int.Parse(splitInput[i]);
            }

            int currentHighest = numbers[0];
            foreach (int current in numbers)
            {
                currentHighest = (current > currentHighest) ? current : currentHighest;
            }

            Console.WriteLine("Highest was: " + currentHighest);
        }
    }
}