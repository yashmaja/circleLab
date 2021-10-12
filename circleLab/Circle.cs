using System;
using System.Collections.Generic;
using System.Text;

namespace circleLab
{
    class Circle
    {
        //properties
        private double Radius;
        public double radius { get; }

        //constructors
        public Circle(double radius)
        {
            Radius = radius;
        }

        //methods
        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return FormatNumber(circumference);
        }

        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public string CalculateFormattedArea()
        {
            double area = Math.PI * Radius * Radius;
            return FormatNumber(area);
        }

        private string FormatNumber(double x)
        {
            return String.Format("{0:00.00}", x);
        }
    }
}
