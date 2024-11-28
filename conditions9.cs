using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your gender");
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "male":
                    Console.WriteLine("Hello Sir!");
                    break;

                case "female":
                    Console.WriteLine("Hello Ma'am!");
                    break;
                default:
                    Console.WriteLine("Invalid gender");
                    break;
            }
        }
    }
}
