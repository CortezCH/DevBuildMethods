using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Best practices
            //  1) Methods should be reusable as possible
            //  2) Methods should generally
            //     (outside of hte main method or one that acts as a manager )
            //     they should have one singular job
            //  3) Methods should account for the most likely inputs (aka parameters)
            //  4) Methods should be defined directly inside of classes
            //  5) Methods are processed in a Last in First out order



            //Getting user input-------------------------------------------
            string result = GetUserInput("Ooga Booga, Are you a ghost? ");
            Console.WriteLine(result);

            //Continue Loop------------------------------------------------
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("I'm Ready");
                keepGoing = Continue();
            }

            //3) Representing Math formulas -> get it right once,
            //then we don't have to worry about the math again-----------
            //      - Area
            //      - Perimeter
            //      - Calculate Paint Cans

            //Area
            int length = 7;
            //Floats must end in an f
            float leng = 1.5f;
            double area = GetArea(length, 5) ;
            Console.WriteLine($"Your area is {area} square feet");
            //all number data types will accept all other number data types.
            area = GetArea(leng, 5);
            Console.WriteLine($"Your area is {area} square feet");

            //4) Range checking - Checking if the input value falls
            //between 1 and 100
            bool inRange = RangeCheck(12, 1, 100);
            Console.WriteLine(inRange);

            Console.WriteLine("Hello World!");
        }

        //1) Getting user input
            //Prompt user
            //Read in their answer
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine().Trim().ToLower();


            return output;
        }

        //2) Continue Loop
        //      Ask the user would you like to continue Y/N
        //          3 cases to care about
        //          User says Y -> continue
        //          User says N -> stop main loop
        //          Anything else -> Try getting input again
        public static bool Continue()
        {
            string answer = GetUserInput("Continue? (y/n): ");

            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter either Y or N to continue.");
                return Continue();
            }

        }

        public static double GetArea(double width, double length)
        {
            double area = length * width;
            return area;
        }

        public static bool RangeCheck(double min, double max, double input)
        {
            if (min < max) 
            {
                if (input < max && input > min)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"The min({min}) was not smaller than the max({max})" +
                    $" and therfore range can't be checked.");
                return false;
            }
            
        }
    }
}
