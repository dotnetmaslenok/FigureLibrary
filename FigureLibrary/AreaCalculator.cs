namespace FigureLibrary;

public static class AreaCalculator
{
    public static double Calculate(IFigure figure)
    {
        return figure.Area();
    }
}