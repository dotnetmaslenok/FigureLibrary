using System.ComponentModel.DataAnnotations;

namespace FigureLibrary;

public sealed class Triangle : IFigure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    
    public Triangle([Range(0, double.MaxValue)] double a, [Range(0, double.MaxValue)] double b, [Range(0, double.MaxValue)] double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Sum of two any sides must be greater then 3rd side value");
        
        A = a;
        B = b;
        C = c;
    }

    public bool IsRight()
    {
        return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);;
    }

    public double Area()
    {
        var semiperimeter = (A + B + C) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
    }
}