using System;

namespace AreaCalc
{
    public class Circle
    {
        public Decimal Area(double width)
        {
            double area = Math.PI * (Math.Pow(width, 2.0));
            return Decimal.Parse(area + "");
        }
    }
}
