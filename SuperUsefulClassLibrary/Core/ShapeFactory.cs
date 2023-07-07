using SuperUsefulClassLibrary.Abstractions;
using SuperUsefulClassLibrary.Implementation;

namespace SuperUsefulClassLibrary.Core;

/// <summary>
/// Factory to create instances of geometric figures
/// <returns>Instance of shape, that based on a given parameters</returns> 
/// </summary>
public static class ShapeFactory
{
    /// <summary name="">
    /// <param name="shapeType">
    /// Figure name. No matter which case
    /// </param>
    /// <returns>Instance of shape, that based on a given parameters type of <see cref="IGeometricFigure"/> </returns>
    /// <code>
    /// Usage example:
    /// IGeometricFigure circle = ShapeFactory.CreateShape("circle", 214);</code> 
    /// </summary>
    public static IGeometricFigure CreateShape(string shapeType, params double[] dimensions)
    {
        switch (shapeType.ToLower())
        {
            case "circle":
                if (dimensions.Length == 1)
                {
                    double radius = dimensions[0];
                    return new Circle(radius);
                }

                throw new ArgumentException("Invalid number of parameters for circle.");

            case "triangle":
                if (dimensions.Length == 3)
                {
                    double sideA = dimensions[0];
                    double sideB = dimensions[1];
                    double sideC = dimensions[2];
                    return new Triangle(sideA, sideB, sideC);
                }

                throw new ArgumentException("Invalid number of parameters");

            default:
                throw new ArgumentException("Unknown geometric figure type ");
        }
    }
}