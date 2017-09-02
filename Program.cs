using System;

namespace week4exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            //get a value from a userinput
            /*Console.WriteLine("Please enter in your first name");
            var fname = Console.ReadLine();
            Console.WriteLine("Please enter in your last name");
            var lname = Console.ReadLine();
            Console.WriteLine($"Your name is {fname} {lname}");*/
            

            //ask the user for a number input
            var counter = 12;
            var i = 0;

            Console.WriteLine("Please enter in a number");
            var number = int.Parse(Console.ReadLine());
            for (i = 0; i < counter; i++)
            {
                var a = i + 1;
                Console.WriteLine($"{number} x {a} = {number * a}");
                Console.ReadLine();
            }

            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

            
        }
    }
}
