using SuperUsefulClassLibrary.Implementation;

namespace SuperUsefulTestProject.GeometricShapesTests;

public class TriangleTests
{
    [Fact]
    public void SurfaceCalculation_WithValidParameters_ShouldReturnValidResult()
    {
        //Arrange
        var expectedResult = 158.74507866387543543009694521836;
        //Act
        var triangle = new Triangle(20, 16, 24);
        var actual = triangle.CalculateArea();
        //Assert
        Assert.Equal(expectedResult, actual, 0.0000001);
    }

    [Fact]
    public void IsSquareTriangle_WithValidParameters_ShouldReturnTrue()
    {
        //Arrange
        var expectedResult = true;
        //Act
        var triangle = new Triangle(3, 4, 5);
        var actual = triangle.IsRightTriangle();
        //Assert
        Assert.Equal(expectedResult, actual);
    }
    
    [Fact]
    public void IsSquareTriangle_WithValidInvalidParameters_ShouldReturnFalse()
    {
        //Arrange
        var expectedResult = true;
        //Act
        var triangle = new Triangle(2, 4, 5);
        var actual = triangle.IsRightTriangle();
        //Assert
        Assert.NotEqual(expectedResult, actual);
    }
}