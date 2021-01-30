﻿using System;

namespace Exercises
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
    }
}