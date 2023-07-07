using SuperUsefulClassLibrary.Abstractions;

namespace SuperUsefulClassLibrary.Implementation;

public sealed class Triangle : IGeometricFigure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        double perimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(
            perimeter * (perimeter - _sideA)
                      * (perimeter - _sideB)
                      * (perimeter - _sideC));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { _sideA, _sideB, _sideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
    }
}