using System;

namespace AreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the area calculator");
            Console.Write("Please select your shape (1 = Cicrle, 2 = Square, 3 = Triangle, 4 = Rectangle): ");
            int option = int.Parse(Console.ReadLine());
            int width;
            if (option == 1)//This is the circle
            {
                
                Console.Write("Please enter in the width of your shape: ");
                width = int.Parse(Console.ReadLine());
            }
            else if(option == 2 || option == 3 || option == 4)//This is any other object
            {
                Console.Write("Please enter in the width of your shape: ");
                width = int.Parse(Console.ReadLine());
                Console.Write("Please enter in the height of your shape: ");
                int height = int.Parse(Console.ReadLine());
            }
            else//This is an error
            {
                Console.WriteLine("That was not and option");
            }
            
        }
    }
}
