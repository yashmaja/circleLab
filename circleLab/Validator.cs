using System;
using System.Collections.Generic;
using System.Text;

namespace circleLab
{
    class Validator
    {
        public static double getRadius()
        {
            double radius = 0;
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
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only. ");
                }
            }

            return radius;
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
