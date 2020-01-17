using System;

namespace AreaCalc
{
    public class Circle
    {
        public Decimal Area(decimal width)
        {
            double area = Math.PI * (Math.Pow(Double.Parse(width + ""), 2.0));
            return Decimal.Parse(area + "");
        }
    }
}
