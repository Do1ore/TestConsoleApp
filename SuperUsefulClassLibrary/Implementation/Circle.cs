using SuperUsefulClassLibrary.Abstractions;

namespace SuperUsefulClassLibrary.Implementation;

public sealed class Circle : IGeometricFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}