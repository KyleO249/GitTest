using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalc
{
    class Reactangle
    {
        // Perimeters of a rectangle
        public decimal length, breadth;

        // Method for calculating area of rectangle
        public decimal reactangleArea()
        {
            length = decimal.Parse(Console.ReadLine());
            breadth = decimal.Parse(Console.ReadLine());
            return length * breadth;
        }
    }
}