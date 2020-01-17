using System;

namespace AreaCalc
{
    public class Circle
    {
        int width;
        public Circle(int width)
        {
            this.width = width;
        }
        public Decimal area()
        {
            Double.Parse(width + "");
            double area = Math.PI * (Math.Pow((Double.Parse(width + "")), 2.0));
            return Decimal.Parse(area + "");
        }
    }
}
