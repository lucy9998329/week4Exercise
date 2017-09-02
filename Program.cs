using System;

namespace week4exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            
            Console.WriteLine("Please enter in your first name");
            var fname = Console.ReadLine();
            Console.WriteLine("Please enter in your last name");
            var lname = Console.ReadLine();
            Console.WriteLine($"Your name is {fname} {lname}");


            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

            
        }
    }
}
