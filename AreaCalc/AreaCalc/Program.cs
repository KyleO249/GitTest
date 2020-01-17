using System;

namespace AreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the area calculator");
            Console.Write("Please select your width for the cicle: ");
            Decimal width = Decimal.Parse(Console.ReadLine());
            Circle circle = new Circle();
            Console.WriteLine("The area of your cicle is: " + circle.Area(width));
            Console.Write("Please select your width for the triangle: ");
            width = Decimal.Parse(Console.ReadLine());
            Triangle triangle = new Triangle();
            Console.WriteLine("The area of your triangle is: " + triangle.Area(width));
            Console.Write("Please select your width for the square: ");
            width = Decimal.Parse(Console.ReadLine());
            Square square = new Square();
            Console.WriteLine("The area of your square is: " + square.calculateSquareArea((double)width));
            Console.Write("Please select your width for the rectangle: ");
            width = Decimal.Parse(Console.ReadLine());
            Console.Write("Please enter in the height of your rectangle: ");
            Decimal height = Decimal.Parse(Console.ReadLine());
            Reactangle rectangle = new Reactangle();
            Console.WriteLine("The area of your square is: " + rectangle.reactangleArea(width, height));
        }
    }
}
