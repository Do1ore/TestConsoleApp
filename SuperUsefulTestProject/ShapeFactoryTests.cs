using SuperUsefulClassLibrary.Core;
using SuperUsefulClassLibrary.Implementation;

namespace SuperUsefulTestProject;

public class ShapeFactoryTests
{
    [Fact]
    public void CircleCreation_WithFigureNameAndParameter_ShouldBeCircleType()
    {
        //Arrange
        var shapeName = "circle";
        //Act
        var actual = ShapeFactory.CreateShape(shapeName, 12);
        //Assert
        Assert.IsType<Circle>(actual);
    }

    [Fact]
    public void TriangleCreation_WithFigureNameAndParameters_ShouldBeTriangleType()
    {
        //Arrange
        var shapeName = "triangle";
        //Act
        var actual = ShapeFactory.CreateShape(shapeName, 12, 12, 34);
        //Assert
        Assert.IsType<Triangle>(actual);
    }

    [Fact]
    public void TriangleCreation_WithInvalidFigureName_ShouldThrowArgumentException()
    {
        //Arrange
        var shapeName = "trianhle";
        double[] dimentions = { 12, 12, 34 };

        //Assert
        Assert.Throws<ArgumentException>(() => ShapeFactory.CreateShape(shapeName, dimentions));
    }
}