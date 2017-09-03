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
            /*var counter = 12;
            var i = 0;

            Console.WriteLine("Please enter in a number");
            var number = int.Parse(Console.ReadLine());
            for (i = 0; i < counter; i++)
            {
                var a = i + 1;
                Console.WriteLine($"{number} x {a} = {number * a}");
                Console.ReadLine();
            }*/

            
            //using forloop to ask for a set of numbers
            /*int counter = 5;
            int number = 0;
            for (var i = 0; i < counter; i++)
            {
                Console.WriteLine("Please enter in a number");
                int userInput = int.Parse(Console.ReadLine());
                number += userInput;
            }
                Console.WriteLine($"The total of the numbers you entered is {number}");
                Console.WriteLine($"The avarage of the numbers you entered is {number/counter}");*/




            /*string Km = "Km";
            string Miles = "Miles";
            Console.WriteLine("Please choose: kilometers or Miles");
            string userChoise = Console.ReadLine();
            if(userChoise == Miles)
            {
                Console.WriteLine("I will convert miles to kilometers. Please enter a number");
                Double miles = Double.Parse(Console.ReadLine());
                Console.WriteLine($"{miles} miles in km is {miles * 1.61}");
                
            }
            if (userChoise == Km)
            {
                Console.WriteLine("I will convert kilometers to Miles. Please enter a number");
                Double kilometers = Double.Parse(Console.ReadLine());
                Console.WriteLine($"{kilometers} km in Mile is {kilometers * 0.62}");
            }*/

            /*string km = "km";
            string Mile = "Miles";
            Console.WriteLine("Please choose the conversion you want to use: Km or Mile");
            string userChoise = Console.ReadLine(); 

            if(userChoise == Mile)
            {
                Console.WriteLine("I will convert Miles to kilometer. Please enter a number");
                Double miles = Double.Parse(Console.ReadLine());
                Double convertMiles = Math.Round(miles * 1.609344, 2);
                Console.WriteLine($"{convertMiles} kilometers");
            }   

            if(userChoise == km)
            {
                Console.WriteLine("I will convert kilometer to Miles. Please enter a number");
                Double kilometer = Double.Parse(Console.ReadLine());
                Double convertkm = Math.Round(kilometer * 0.62137119, 2);
                Console.WriteLine($"{convertkm} Miles");
            } */



            //diameter of the circle
           /* const double pi = 3.14;
            Console.WriteLine("What is the diameter of the circle?");
            int dia = int.Parse(Console.ReadLine());
            double rad = dia/2;
            double cir = 2*pi*rad;
            Console.WriteLine($"the circunference of the circle is {cir}");*/         



            //finding the area
            int side1;
            int side2;
            Console.WriteLine("What is the length of the first side");
            side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the length of the second side");
            side2 = int.Parse(Console.ReadLine());
            int perimeter = (side1 + side2)*2;
            int area = side1 * side2;
            Console.WriteLine($"The perimeter of the shape is {perimeter}");
            Console.WriteLine($"The area of the shape is {area}");
            




            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

            
        }
    }
}
