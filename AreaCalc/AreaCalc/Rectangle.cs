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
            Console.WriteLine("Length of rectangle");
            length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Breadth of rectangle");
            breadth = decimal.Parse(Console.ReadLine());
            return length * breadth;
        }
    }
}