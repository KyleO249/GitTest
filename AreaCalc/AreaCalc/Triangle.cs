using System;

public class Triangle
{
    decimal Length;
    public Triangle(decimal Side)
    {
        this.Length = Side;
    }

    public decimal Area()
    {
        decimal Area = (Length * Length) / 4;
        return Area;
    }
}
