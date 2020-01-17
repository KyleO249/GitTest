using System;

namespace Git_test
{
    class Square
    {
      
        public void calculateSquareArea()
        {
            Console.Write("a = ");
            int length = int.Parse(Console.ReadLine());
            int area = length * length;
            Console.Write("Square area = " + area);
            

        }
        
    }
}
