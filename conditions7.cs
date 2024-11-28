using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was it over the line?");
            string goal = Console.ReadLine();

            if(goal == "true" || goal == "TRUE")
            {
                Console.WriteLine("gooooooaaaaaaaallllll");
            }
            else
            {
                Console.WriteLine("so close");
            }
        }
    }
}
