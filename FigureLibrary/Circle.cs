using System.ComponentModel.DataAnnotations;

namespace FigureLibrary;

public sealed class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle([Range(0, double.MaxValue)] double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}