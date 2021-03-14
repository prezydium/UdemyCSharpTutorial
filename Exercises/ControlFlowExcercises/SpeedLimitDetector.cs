using System;

namespace Exercises.ControlFlowExcercises
{
    public class SpeedLimitDetector
    {
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