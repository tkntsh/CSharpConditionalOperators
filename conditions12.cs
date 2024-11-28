using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 2;

            if(score == 1)
            {
                Console.WriteLine("1 goal");
            }
            else if (score == 2)
            {
                Console.WriteLine("2 goals");
            }
            else
            {
                Console.WriteLine("goal-less");
            }
        }
    }
}
