using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 16;
            string decision = (age < 18) ?
                "Too young" : "Old enough";
            
            Console.WriteLine(decision);
        }
    }
}
