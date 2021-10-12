using System;

namespace circleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            bool repeat = true;
            int numOfCircles = 0;

            while (repeat)
            {
                Console.Write("Enter radius: ");

                double radius = Validator.getRadius();

                Circle newCircle = new Circle(radius);
                numOfCircles++;

                Console.WriteLine($"Circumference: {newCircle.CalculateFormattedCircumference()}.");
                Console.WriteLine($"Area: {newCircle.CalculateFormattedArea()}");

                repeat = Validator.Repeat();
            }

            Console.WriteLine($"You created {numOfCircles} circles.");
        }
    }
}
