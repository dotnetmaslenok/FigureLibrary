namespace FigureLibrary.Tests;

public sealed class BasicsScenarioTests
{
    [Theory]
    [InlineData(3, 4, 5)]
    public void CalculateTriangleArea_ShouldReturnValue_WhenItExists(double a, double b, double c)
    {
        Assert.Equal(6, AreaCalculator.Calculate(new Triangle(a ,b ,c)));
    }

    [Theory]
    [InlineData(3, 5, 20)]
    [InlineData(5, 15, 22)]
    [InlineData(413, 123, 2)]
    public void CalculateTriangleArea_ShouldThrowException_WhenItNotExists(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => AreaCalculator.Calculate(new Triangle(a, b, c)));
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(15, 20, 25)]
    [InlineData(11, 60, 61)]
    public void IsTriangleRight_ShouldReturnTrue_WhenArgsValid(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.True(triangle.IsRight());
    }

    [Theory]
    [InlineData(3, 4, 6)]
    [InlineData(15, 21, 25)]
    [InlineData(44, 60, 75)]
    public void IsTriangleRight_ShouldReturnFalse_WhenArgsInvalid(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.False(triangle.IsRight());
    }

    [Theory]
    [InlineData(6)]
    public void CalculateCircleArea_ShouldReturnValue_WhenRadiusValid(double radius)
    {
        Assert.Equal(113, Convert.ToInt64(AreaCalculator.Calculate(new Circle(radius))));
    }
}