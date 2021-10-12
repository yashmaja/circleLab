using System;

namespace circleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            bool repeat = true;
            double radius = 0;
            int numOfCircles = 0;

            while (repeat)
            {
                Console.Write("Enter radius: ");

                while (true)
                {
                    try
                    {
                        radius = double.Parse(Console.ReadLine());
                        if (radius < 0)
                        {
                            throw new Exception("Please enter a positive number.");
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input. Please enter numbers only. ");
                    }
                }

                Circle newCircle = new Circle(radius);
                numOfCircles++;

                Console.WriteLine($"Circumference: {newCircle.CalculateFormattedCircumference()}.");
                Console.WriteLine($"Area: {newCircle.CalculateFormattedArea()}");

                repeat = Repeat();
            }

            Console.WriteLine($"You created {numOfCircles} circles.");
        }

        public static bool Repeat()
        {
            while (true)
            {
                Console.Write("\nAnother circle? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    Console.WriteLine("\nGoodbye!");
                    return false;
                }
                else if (answer == "y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.\n");
                }
            }
        }
    }
}
