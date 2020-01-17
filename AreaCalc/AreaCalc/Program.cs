using System;

namespace AreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the area calculator");
            Console.Write("Please select your width for the cicle: ");
            int width = int.Parse(Console.ReadLine());
            Circle circle = new Circle(width);
            Console.WriteLine("The area of your cicle is: " + circle.Area());
            Console.Write("Please select your width for the triangle: ");
            width = int.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(width);
            Console.WriteLine("The area of your triangle is: " + triangle.Area());
            Console.Write("Please select your width for the square: ");
            width = int.Parse(Console.ReadLine())
            Square square = new Square(width);
            Console.WriteLine("The area of your square is: " + square.Area());
            Console.Write("Please select your width for the rectangle: ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Please enter in the height of your rectangle: ");
            int height = int.Parse(Console.ReadLine())
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("The area of your square is: " + rectangle.Area());
        }
    }
}
